using System;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }

        void Drive();
        
    }
}