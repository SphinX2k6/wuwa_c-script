using System;
using Aki.Config;

// Token: 0x02000919 RID: 2329
public struct IRegressRewardItemInfo
{
	// Token: 0x17000CF7 RID: 3319
	// (get) Token: 0x06006707 RID: 26375 RVA: 0x0020440B File Offset: 0x0020260B
	// (set) Token: 0x06006708 RID: 26376 RVA: 0x00204413 File Offset: 0x00202613
	public ItemInfo? ItemInfo { readonly get; set; }

	// Token: 0x17000CF8 RID: 3320
	// (get) Token: 0x06006709 RID: 26377 RVA: 0x0020441C File Offset: 0x0020261C
	// (set) Token: 0x0600670A RID: 26378 RVA: 0x00204424 File Offset: 0x00202624
	public int ItemCount { readonly get; set; }

	// Token: 0x17000CF9 RID: 3321
	// (get) Token: 0x0600670B RID: 26379 RVA: 0x0020442D File Offset: 0x0020262D
	// (set) Token: 0x0600670C RID: 26380 RVA: 0x00204435 File Offset: 0x00202635
	public ERegressRewardState RewardState { readonly get; set; }
}
