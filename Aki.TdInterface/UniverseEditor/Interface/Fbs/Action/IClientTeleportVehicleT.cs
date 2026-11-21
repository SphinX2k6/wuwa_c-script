using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7E RID: 27262
	public class IClientTeleportVehicleT
	{
		// Token: 0x1700C836 RID: 51254
		// (get) Token: 0x0602EC66 RID: 191590 RVA: 0x0065FF22 File Offset: 0x0065E122
		// (set) Token: 0x0602EC67 RID: 191591 RVA: 0x0065FF2A File Offset: 0x0065E12A
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700C837 RID: 51255
		// (get) Token: 0x0602EC68 RID: 191592 RVA: 0x0065FF33 File Offset: 0x0065E133
		// (set) Token: 0x0602EC69 RID: 191593 RVA: 0x0065FF3B File Offset: 0x0065E13B
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C838 RID: 51256
		// (get) Token: 0x0602EC6A RID: 191594 RVA: 0x0065FF44 File Offset: 0x0065E144
		// (set) Token: 0x0602EC6B RID: 191595 RVA: 0x0065FF4C File Offset: 0x0065E14C
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0602EC6C RID: 191596 RVA: 0x0065FF55 File Offset: 0x0065E155
		public IClientTeleportVehicleT()
		{
			this.TargetVehicle = null;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
