using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Assignment_2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Shape
        {
            public string ID {get; set; }
            public string Name {get; set; } 
            public string Color { get; set; }
            

            static double CalculateArea(double x, double y)
            {
                double Area = x * y;
                return Area; 
            }
            public class Circle : Shape
            {
                public double radius {get; set; }

                static double CalculateArea( double x)
                {
                    return Math.PI * (x * x);
                }

            }
            public class Square : Shape
            {
                
            }

        }

    }
}
