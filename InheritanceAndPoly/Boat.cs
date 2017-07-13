using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPoly
{
    class Boat : Vehicle
    {
        // Field
        private double waterDrag;

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
            
        }

        public Boat()
        {
            // DEFAULT need a construstor 
        }

        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag; // += meaning e.g : distanceTraveled += distanceTraveled + movementSpeed
        }
    }
}
