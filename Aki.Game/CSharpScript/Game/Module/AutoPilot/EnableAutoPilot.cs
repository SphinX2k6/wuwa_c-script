using System;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E71 RID: 24177
	public class EnableAutoPilot : AutoPilotDefine.IEnableAutoPilot
	{
		// Token: 0x17008E7E RID: 36478
		// (get) Token: 0x0603D7E2 RID: 251874 RVA: 0x00ED7467 File Offset: 0x00ED5667
		// (set) Token: 0x0603D7E3 RID: 251875 RVA: 0x00ED746F File Offset: 0x00ED566F
		public AutoPilotDefine.EEnableAutoPilot Value { get; set; }

		// Token: 0x17008E7F RID: 36479
		// (get) Token: 0x0603D7E4 RID: 251876 RVA: 0x00ED7478 File Offset: 0x00ED5678
		// (set) Token: 0x0603D7E5 RID: 251877 RVA: 0x00ED7480 File Offset: 0x00ED5680
		public AutoPilotDefine.EDisableAutoPilotReason? DisableReason { get; set; }
	}
}
