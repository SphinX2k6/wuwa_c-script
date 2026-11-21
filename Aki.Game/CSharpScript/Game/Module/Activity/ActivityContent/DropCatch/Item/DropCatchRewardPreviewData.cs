using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005630 RID: 22064
	public class DropCatchRewardPreviewData : IDropCatchRewardPreviewData
	{
		// Token: 0x1700698D RID: 27021
		// (get) Token: 0x0603688A RID: 223370 RVA: 0x00F38211 File Offset: 0x00F36411
		// (set) Token: 0x0603688B RID: 223371 RVA: 0x00F38219 File Offset: 0x00F36419
		public int CfgId { get; set; }

		// Token: 0x1700698E RID: 27022
		// (get) Token: 0x0603688C RID: 223372 RVA: 0x00F38222 File Offset: 0x00F36422
		// (set) Token: 0x0603688D RID: 223373 RVA: 0x00F3822A File Offset: 0x00F3642A
		public EDropCatchLevelState? State { get; set; }

		// Token: 0x1700698F RID: 27023
		// (get) Token: 0x0603688E RID: 223374 RVA: 0x00F38233 File Offset: 0x00F36433
		// (set) Token: 0x0603688F RID: 223375 RVA: 0x00F3823B File Offset: 0x00F3643B
		public bool IsLast { get; set; }
	}
}
