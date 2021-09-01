using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        string AnimalName = "Dog";
        string color = "White";

        public void Sound()
        {
            Console.WriteLine("Bow Bow");
        }
        static void Main(string[] args)
        {
            Animal MyObj = new Animal();
            Console.WriteLine(MyObj.AnimalName);
            Console.WriteLine(MyObj.color);
            MyObj.Sound();
            Console.ReadLine();
        }
    }
}
