using System;

// Token: 0x0200152B RID: 5419
public interface ITowerGuideRewardItem
{
	// Token: 0x17000D46 RID: 3398
	// (get) Token: 0x06009A8F RID: 39567
	// (set) Token: 0x06009A90 RID: 39568
	TItem Item { get; set; }

	// Token: 0x17000D47 RID: 3399
	// (get) Token: 0x06009A91 RID: 39569
	// (set) Token: 0x06009A92 RID: 39570
	bool IsLock { get; set; }

	// Token: 0x17000D48 RID: 3400
	// (get) Token: 0x06009A93 RID: 39571
	// (set) Token: 0x06009A94 RID: 39572
	bool IsReceivableVisible { get; set; }
}
