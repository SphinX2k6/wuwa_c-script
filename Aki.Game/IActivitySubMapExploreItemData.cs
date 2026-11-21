using System;
using System.Runtime.CompilerServices;

// Token: 0x0200077A RID: 1914
[NullableContext(1)]
public interface IActivitySubMapExploreItemData
{
	// Token: 0x17000B58 RID: 2904
	// (get) Token: 0x060057A9 RID: 22441
	// (set) Token: 0x060057AA RID: 22442
	int TaskId { get; set; }

	// Token: 0x17000B59 RID: 2905
	// (get) Token: 0x060057AB RID: 22443
	// (set) Token: 0x060057AC RID: 22444
	string RewardDesc { get; set; }

	// Token: 0x17000B5A RID: 2906
	// (get) Token: 0x060057AD RID: 22445
	// (set) Token: 0x060057AE RID: 22446
	int RewardItemId { get; set; }

	// Token: 0x17000B5B RID: 2907
	// (get) Token: 0x060057AF RID: 22447
	// (set) Token: 0x060057B0 RID: 22448
	int? RewardItemCount { get; set; }

	// Token: 0x17000B5C RID: 2908
	// (get) Token: 0x060057B1 RID: 22449
	// (set) Token: 0x060057B2 RID: 22450
	bool IsComplete { get; set; }

	// Token: 0x17000B5D RID: 2909
	// (get) Token: 0x060057B3 RID: 22451
	// (set) Token: 0x060057B4 RID: 22452
	bool IsCanGet { get; set; }

	// Token: 0x17000B5E RID: 2910
	// (get) Token: 0x060057B5 RID: 22453
	// (set) Token: 0x060057B6 RID: 22454
	bool IsRunning { get; set; }
}
