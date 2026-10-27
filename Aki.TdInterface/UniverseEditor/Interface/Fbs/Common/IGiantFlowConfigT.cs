using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DBC RID: 23996
	public class IGiantFlowConfigT
	{
		// Token: 0x1700B3AA RID: 45994
		// (get) Token: 0x06029126 RID: 168230 RVA: 0x005A37E9 File Offset: 0x005A19E9
		// (set) Token: 0x06029127 RID: 168231 RVA: 0x005A37F1 File Offset: 0x005A19F1
		public string FlowListName { get; set; }

		// Token: 0x1700B3AB RID: 45995
		// (get) Token: 0x06029128 RID: 168232 RVA: 0x005A37FA File Offset: 0x005A19FA
		// (set) Token: 0x06029129 RID: 168233 RVA: 0x005A3802 File Offset: 0x005A1A02
		public int FlowId { get; set; }

		// Token: 0x1700B3AC RID: 45996
		// (get) Token: 0x0602912A RID: 168234 RVA: 0x005A380B File Offset: 0x005A1A0B
		// (set) Token: 0x0602912B RID: 168235 RVA: 0x005A3813 File Offset: 0x005A1A13
		public int StateId { get; set; }

		// Token: 0x0602912C RID: 168236 RVA: 0x005A381C File Offset: 0x005A1A1C
		public IGiantFlowConfigT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
		}
	}
}
