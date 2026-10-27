using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007389 RID: 29577
	public class ITeleportToAndEnterVehicleT
	{
		// Token: 0x1700E08E RID: 57486
		// (get) Token: 0x06035B09 RID: 219913 RVA: 0x0074F581 File Offset: 0x0074D781
		// (set) Token: 0x06035B0A RID: 219914 RVA: 0x0074F589 File Offset: 0x0074D789
		public ITeleportToAndEnterFishingBoatT ToVehicle { get; set; }

		// Token: 0x06035B0B RID: 219915 RVA: 0x0074F592 File Offset: 0x0074D792
		public ITeleportToAndEnterVehicleT()
		{
			this.ToVehicle = null;
		}
	}
}
