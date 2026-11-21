using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x0200562F RID: 22063
	public interface IDropCatchRewardPreviewData
	{
		// Token: 0x1700698A RID: 27018
		// (get) Token: 0x06036884 RID: 223364
		// (set) Token: 0x06036885 RID: 223365
		int CfgId { get; set; }

		// Token: 0x1700698B RID: 27019
		// (get) Token: 0x06036886 RID: 223366
		// (set) Token: 0x06036887 RID: 223367
		EDropCatchLevelState? State { get; set; }

		// Token: 0x1700698C RID: 27020
		// (get) Token: 0x06036888 RID: 223368
		// (set) Token: 0x06036889 RID: 223369
		bool IsLast { get; set; }
	}
}
