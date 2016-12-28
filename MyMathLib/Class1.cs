using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLib
{
    public static class Arithmetic
    {
        public static double Add(double one, double two)
        {
            return one + two;
        }

        public static double Subtract(double one, double two)
        {
            return one - two;
        }

        public static double Multiply(double one, double two)
        {
            return one * two;
        }

        public static double Divide(double one, double two)
        {
            //if (two == 0) throw new DivideByZeroException();
            return one / two;
        }

        public static double Inverse(double one)
        {
            return Divide(1.0, one);
        }

        public static double Sin(double one)
        {
            return Math.Round(1.0 / (1.0 / Math.Round(Math.Sin(one * Math.PI / 180), 8)), 8);
        }

        public static double Cos(double one)
        {
            return Math.Round(1.0 / (1.0 / Math.Round(Math.Cos(one * Math.PI / 180), 8)), 8);
        }

        public static double Tan(double one)
        {
            return Sin(one) / Cos(one);
        }

        public static double CubicRoot(double one)
        {
            return Math.Pow(one, (1.0 / 3.0));
        }

        public static double Square(double one)
        {
            return one * one;
        }
    }
}
