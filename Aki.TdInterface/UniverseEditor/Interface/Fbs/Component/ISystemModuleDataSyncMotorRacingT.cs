using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A23 RID: 23075
	public class ISystemModuleDataSyncMotorRacingT
	{
		// Token: 0x1700AD74 RID: 44404
		// (get) Token: 0x06027311 RID: 160529 RVA: 0x00564189 File Offset: 0x00562389
		// (set) Token: 0x06027312 RID: 160530 RVA: 0x00564191 File Offset: 0x00562391
		public ESyncDataSystemType Type { get; set; }

		// Token: 0x1700AD75 RID: 44405
		// (get) Token: 0x06027313 RID: 160531 RVA: 0x0056419A File Offset: 0x0056239A
		// (set) Token: 0x06027314 RID: 160532 RVA: 0x005641A2 File Offset: 0x005623A2
		public int MotorParkourId { get; set; }

		// Token: 0x1700AD76 RID: 44406
		// (get) Token: 0x06027315 RID: 160533 RVA: 0x005641AB File Offset: 0x005623AB
		// (set) Token: 0x06027316 RID: 160534 RVA: 0x005641B3 File Offset: 0x005623B3
		public List<IMotorParkourSystemVarT> Vars { get; set; }

		// Token: 0x06027317 RID: 160535 RVA: 0x005641BC File Offset: 0x005623BC
		public ISystemModuleDataSyncMotorRacingT()
		{
			this.Type = ESyncDataSystemType.MotorRacing;
			this.MotorParkourId = 0;
			this.Vars = null;
		}
	}
}
