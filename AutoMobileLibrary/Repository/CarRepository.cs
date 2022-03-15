using AutoMobileLibrary.BusinessObject;
using AutoMobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;

        public Car GetCarByID(int carId) => CarDBContext.Instance.GetCarByID(carId);

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
