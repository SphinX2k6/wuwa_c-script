using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B70 RID: 31600
	public class ITeleportToAndEnterVehicleT
	{
		// Token: 0x1700EC9E RID: 60574
		// (get) Token: 0x06038EA4 RID: 233124 RVA: 0x007B1AC1 File Offset: 0x007AFCC1
		// (set) Token: 0x06038EA5 RID: 233125 RVA: 0x007B1AC9 File Offset: 0x007AFCC9
		public ITeleportToAndEnterFishingBoatT ToVehicle { get; set; }

		// Token: 0x06038EA6 RID: 233126 RVA: 0x007B1AD2 File Offset: 0x007AFCD2
		public ITeleportToAndEnterVehicleT()
		{
			this.ToVehicle = null;
		}
	}
}
