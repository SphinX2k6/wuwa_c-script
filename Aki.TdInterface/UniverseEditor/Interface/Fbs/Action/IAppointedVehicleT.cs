using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006800 RID: 26624
	public class IAppointedVehicleT
	{
		// Token: 0x1700C3B6 RID: 50102
		// (get) Token: 0x0602D7A5 RID: 186277 RVA: 0x00639E40 File Offset: 0x00638040
		// (set) Token: 0x0602D7A6 RID: 186278 RVA: 0x00639E48 File Offset: 0x00638048
		public ETargetVehicle Type { get; set; }

		// Token: 0x1700C3B7 RID: 50103
		// (get) Token: 0x0602D7A7 RID: 186279 RVA: 0x00639E51 File Offset: 0x00638051
		// (set) Token: 0x0602D7A8 RID: 186280 RVA: 0x00639E59 File Offset: 0x00638059
		public int VehicleId { get; set; }

		// Token: 0x0602D7A9 RID: 186281 RVA: 0x00639E62 File Offset: 0x00638062
		public IAppointedVehicleT()
		{
			this.Type = ETargetVehicle.Current;
			this.VehicleId = 0;
		}
	}
}
