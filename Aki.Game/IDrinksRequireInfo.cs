using System;

// Token: 0x02000F3F RID: 3903
public interface IDrinksRequireInfo
{
	// Token: 0x1700079F RID: 1951
	// (get) Token: 0x0600638C RID: 25484
	// (set) Token: 0x0600638D RID: 25485
	int RequireId { get; set; }

	// Token: 0x170007A0 RID: 1952
	// (get) Token: 0x0600638E RID: 25486
	// (set) Token: 0x0600638F RID: 25487
	EDrinksRequireType Type { get; set; }

	// Token: 0x170007A1 RID: 1953
	// (get) Token: 0x06006390 RID: 25488
	// (set) Token: 0x06006391 RID: 25489
	int? FlavorRangeId { get; set; }

	// Token: 0x170007A2 RID: 1954
	// (get) Token: 0x06006392 RID: 25490
	// (set) Token: 0x06006393 RID: 25491
	bool Completed { get; set; }
}
