using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F9 RID: 25593
	public class IGiantFlowConfigT
	{
		// Token: 0x1700BD10 RID: 48400
		// (get) Token: 0x0602B7B0 RID: 178096 RVA: 0x005EC519 File Offset: 0x005EA719
		// (set) Token: 0x0602B7B1 RID: 178097 RVA: 0x005EC521 File Offset: 0x005EA721
		public string FlowListName { get; set; }

		// Token: 0x1700BD11 RID: 48401
		// (get) Token: 0x0602B7B2 RID: 178098 RVA: 0x005EC52A File Offset: 0x005EA72A
		// (set) Token: 0x0602B7B3 RID: 178099 RVA: 0x005EC532 File Offset: 0x005EA732
		public int FlowId { get; set; }

		// Token: 0x1700BD12 RID: 48402
		// (get) Token: 0x0602B7B4 RID: 178100 RVA: 0x005EC53B File Offset: 0x005EA73B
		// (set) Token: 0x0602B7B5 RID: 178101 RVA: 0x005EC543 File Offset: 0x005EA743
		public int StateId { get; set; }

		// Token: 0x0602B7B6 RID: 178102 RVA: 0x005EC54C File Offset: 0x005EA74C
		public IGiantFlowConfigT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
		}
	}
}
