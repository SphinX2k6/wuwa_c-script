using System;

// Token: 0x0200151B RID: 5403
public interface IKingShipResultViewData
{
	// Token: 0x17001405 RID: 5125
	// (get) Token: 0x0600D827 RID: 55335
	// (set) Token: 0x0600D828 RID: 55336
	int CardId { get; set; }

	// Token: 0x17001406 RID: 5126
	// (get) Token: 0x0600D829 RID: 55337
	// (set) Token: 0x0600D82A RID: 55338
	int ReignsId { get; set; }

	// Token: 0x17001407 RID: 5127
	// (get) Token: 0x0600D82B RID: 55339
	// (set) Token: 0x0600D82C RID: 55340
	bool IsSuccess { get; set; }

	// Token: 0x17001408 RID: 5128
	// (get) Token: 0x0600D82D RID: 55341
	// (set) Token: 0x0600D82E RID: 55342
	int NextReignsId { get; set; }
}
