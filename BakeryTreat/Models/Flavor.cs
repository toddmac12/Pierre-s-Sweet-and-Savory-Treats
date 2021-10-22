using System.Collections.Generic;

namespace BakeryTreat.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }

        public int FlavorId { get; set; }
        public string FlavorType { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<TreatFlavor> Treats { get;}
    }
}