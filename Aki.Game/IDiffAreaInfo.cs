using System;

// Token: 0x020020C2 RID: 8386
internal interface IDiffAreaInfo
{
	// Token: 0x17001EFE RID: 7934
	// (get) Token: 0x060149CF RID: 84431
	// (set) Token: 0x060149D0 RID: 84432
	ESurvivorsLevelDiff Diff { get; set; }

	// Token: 0x17001EFF RID: 7935
	// (get) Token: 0x060149D1 RID: 84433
	// (set) Token: 0x060149D2 RID: 84434
	int LowerBoundLevelId { get; set; }

	// Token: 0x17001F00 RID: 7936
	// (get) Token: 0x060149D3 RID: 84435
	// (set) Token: 0x060149D4 RID: 84436
	float LowerBoundPosY { get; set; }
}
