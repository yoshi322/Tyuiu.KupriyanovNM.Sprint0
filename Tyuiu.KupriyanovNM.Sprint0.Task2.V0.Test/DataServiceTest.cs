using Tyuiu.KupriyanovNM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KupriyanovNM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMesageValid()
        {
            var name = "никита";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("привет, никита", res);
        }
    }
}
