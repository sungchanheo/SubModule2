using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Dog : Animal, IAnimal
    {
        public string Bark { get; set; }

        public string Kind { get; set; }

        public string Color { get; set; }
        public string Race { get; set; }
    }
}
