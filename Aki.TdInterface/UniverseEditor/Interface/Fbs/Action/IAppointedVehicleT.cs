using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006195 RID: 24981
	public class IAppointedVehicleT
	{
		// Token: 0x1700BA38 RID: 47672
		// (get) Token: 0x0602B074 RID: 176244 RVA: 0x005EF5CC File Offset: 0x005ED7CC
		// (set) Token: 0x0602B075 RID: 176245 RVA: 0x005EF5D4 File Offset: 0x005ED7D4
		public ETargetVehicle Type { get; set; }

		// Token: 0x1700BA39 RID: 47673
		// (get) Token: 0x0602B076 RID: 176246 RVA: 0x005EF5DD File Offset: 0x005ED7DD
		// (set) Token: 0x0602B077 RID: 176247 RVA: 0x005EF5E5 File Offset: 0x005ED7E5
		public int VehicleId { get; set; }

		// Token: 0x0602B078 RID: 176248 RVA: 0x005EF5EE File Offset: 0x005ED7EE
		public IAppointedVehicleT()
		{
			this.Type = ETargetVehicle.Current;
			this.VehicleId = 0;
		}
	}
}
