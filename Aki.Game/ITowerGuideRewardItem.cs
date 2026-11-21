using System;

// Token: 0x020009E3 RID: 2531
public interface ITowerGuideRewardItem
{
	// Token: 0x17000D67 RID: 3431
	// (get) Token: 0x06006E6D RID: 28269
	// (set) Token: 0x06006E6E RID: 28270
	TItem Item { get; set; }

	// Token: 0x17000D68 RID: 3432
	// (get) Token: 0x06006E6F RID: 28271
	// (set) Token: 0x06006E70 RID: 28272
	bool IsLock { get; set; }

	// Token: 0x17000D69 RID: 3433
	// (get) Token: 0x06006E71 RID: 28273
	// (set) Token: 0x06006E72 RID: 28274
	bool IsReceivableVisible { get; set; }
}
