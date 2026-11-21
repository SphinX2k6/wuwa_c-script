using System;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E56 RID: 20054
	public class EnableAutoPilot : AutoPilotDefine.IEnableAutoPilot
	{
		// Token: 0x17006250 RID: 25168
		// (get) Token: 0x06032772 RID: 206706 RVA: 0x00E289F3 File Offset: 0x00E26BF3
		// (set) Token: 0x06032773 RID: 206707 RVA: 0x00E289FB File Offset: 0x00E26BFB
		public AutoPilotDefine.EEnableAutoPilot Value { get; set; }

		// Token: 0x17006251 RID: 25169
		// (get) Token: 0x06032774 RID: 206708 RVA: 0x00E28A04 File Offset: 0x00E26C04
		// (set) Token: 0x06032775 RID: 206709 RVA: 0x00E28A0C File Offset: 0x00E26C0C
		public AutoPilotDefine.EDisableAutoPilotReason? DisableReason { get; set; }
	}
}
