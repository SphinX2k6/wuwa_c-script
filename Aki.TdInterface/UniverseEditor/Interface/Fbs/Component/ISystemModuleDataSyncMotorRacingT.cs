using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006030 RID: 24624
	public class ISystemModuleDataSyncMotorRacingT
	{
		// Token: 0x1700B6AC RID: 46764
		// (get) Token: 0x06029889 RID: 170121 RVA: 0x005AB14D File Offset: 0x005A934D
		// (set) Token: 0x0602988A RID: 170122 RVA: 0x005AB155 File Offset: 0x005A9355
		public ESyncDataSystemType Type { get; set; }

		// Token: 0x1700B6AD RID: 46765
		// (get) Token: 0x0602988B RID: 170123 RVA: 0x005AB15E File Offset: 0x005A935E
		// (set) Token: 0x0602988C RID: 170124 RVA: 0x005AB166 File Offset: 0x005A9366
		public int MotorParkourId { get; set; }

		// Token: 0x1700B6AE RID: 46766
		// (get) Token: 0x0602988D RID: 170125 RVA: 0x005AB16F File Offset: 0x005A936F
		// (set) Token: 0x0602988E RID: 170126 RVA: 0x005AB177 File Offset: 0x005A9377
		public List<IMotorParkourSystemVarT> Vars { get; set; }

		// Token: 0x0602988F RID: 170127 RVA: 0x005AB180 File Offset: 0x005A9380
		public ISystemModuleDataSyncMotorRacingT()
		{
			this.Type = ESyncDataSystemType.MotorRacing;
			this.MotorParkourId = 0;
			this.Vars = null;
		}
	}
}
