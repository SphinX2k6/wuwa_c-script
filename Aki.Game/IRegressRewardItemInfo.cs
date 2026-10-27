using System;
using Aki.Config;

// Token: 0x02001465 RID: 5221
public struct IRegressRewardItemInfo
{
	// Token: 0x17000CD7 RID: 3287
	// (get) Token: 0x06009372 RID: 37746 RVA: 0x001FB603 File Offset: 0x001F9803
	// (set) Token: 0x06009373 RID: 37747 RVA: 0x001FB60B File Offset: 0x001F980B
	public ItemInfo? ItemInfo { readonly get; set; }

	// Token: 0x17000CD8 RID: 3288
	// (get) Token: 0x06009374 RID: 37748 RVA: 0x001FB614 File Offset: 0x001F9814
	// (set) Token: 0x06009375 RID: 37749 RVA: 0x001FB61C File Offset: 0x001F981C
	public int ItemCount { readonly get; set; }

	// Token: 0x17000CD9 RID: 3289
	// (get) Token: 0x06009376 RID: 37750 RVA: 0x001FB625 File Offset: 0x001F9825
	// (set) Token: 0x06009377 RID: 37751 RVA: 0x001FB62D File Offset: 0x001F982D
	public ERegressRewardState RewardState { readonly get; set; }
}
