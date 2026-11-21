using System;

// Token: 0x020009F3 RID: 2547
public interface ITurntableReward
{
	// Token: 0x17000D75 RID: 3445
	// (get) Token: 0x06006F4A RID: 28490
	// (set) Token: 0x06006F4B RID: 28491
	int Id { get; set; }

	// Token: 0x17000D76 RID: 3446
	// (get) Token: 0x06006F4C RID: 28492
	// (set) Token: 0x06006F4D RID: 28493
	int RoundId { get; set; }

	// Token: 0x17000D77 RID: 3447
	// (get) Token: 0x06006F4E RID: 28494
	// (set) Token: 0x06006F4F RID: 28495
	bool IsClaimed { get; set; }

	// Token: 0x17000D78 RID: 3448
	// (get) Token: 0x06006F50 RID: 28496
	// (set) Token: 0x06006F51 RID: 28497
	TItem RewardItem { get; set; }

	// Token: 0x17000D79 RID: 3449
	// (get) Token: 0x06006F52 RID: 28498
	// (set) Token: 0x06006F53 RID: 28499
	bool IsSpecial { get; set; }
}
