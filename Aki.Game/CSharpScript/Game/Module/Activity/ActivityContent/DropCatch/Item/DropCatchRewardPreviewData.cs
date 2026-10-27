using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066E0 RID: 26336
	public class DropCatchRewardPreviewData : IDropCatchRewardPreviewData
	{
		// Token: 0x1700964E RID: 38478
		// (get) Token: 0x06041D3E RID: 269630 RVA: 0x00FF6E0D File Offset: 0x00FF500D
		// (set) Token: 0x06041D3F RID: 269631 RVA: 0x00FF6E15 File Offset: 0x00FF5015
		public int CfgId { get; set; }

		// Token: 0x1700964F RID: 38479
		// (get) Token: 0x06041D40 RID: 269632 RVA: 0x00FF6E1E File Offset: 0x00FF501E
		// (set) Token: 0x06041D41 RID: 269633 RVA: 0x00FF6E26 File Offset: 0x00FF5026
		public EDropCatchLevelState? State { get; set; }

		// Token: 0x17009650 RID: 38480
		// (get) Token: 0x06041D42 RID: 269634 RVA: 0x00FF6E2F File Offset: 0x00FF502F
		// (set) Token: 0x06041D43 RID: 269635 RVA: 0x00FF6E37 File Offset: 0x00FF5037
		public bool IsLast { get; set; }
	}
}
