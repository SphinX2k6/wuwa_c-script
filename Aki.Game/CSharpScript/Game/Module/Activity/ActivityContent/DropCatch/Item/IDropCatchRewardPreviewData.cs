using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066DF RID: 26335
	public interface IDropCatchRewardPreviewData
	{
		// Token: 0x1700964B RID: 38475
		// (get) Token: 0x06041D38 RID: 269624
		// (set) Token: 0x06041D39 RID: 269625
		int CfgId { get; set; }

		// Token: 0x1700964C RID: 38476
		// (get) Token: 0x06041D3A RID: 269626
		// (set) Token: 0x06041D3B RID: 269627
		EDropCatchLevelState? State { get; set; }

		// Token: 0x1700964D RID: 38477
		// (get) Token: 0x06041D3C RID: 269628
		// (set) Token: 0x06041D3D RID: 269629
		bool IsLast { get; set; }
	}
}
