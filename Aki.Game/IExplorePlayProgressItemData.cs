using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F65 RID: 3941
[NullableContext(2)]
public interface IExplorePlayProgressItemData
{
	// Token: 0x170010B7 RID: 4279
	// (get) Token: 0x06009E07 RID: 40455
	// (set) Token: 0x06009E08 RID: 40456
	EExploreType ExploreType { get; set; }

	// Token: 0x170010B8 RID: 4280
	// (get) Token: 0x06009E09 RID: 40457
	// (set) Token: 0x06009E0A RID: 40458
	EPlayPointType PlayPointType { get; set; }

	// Token: 0x170010B9 RID: 4281
	// (get) Token: 0x06009E0B RID: 40459
	// (set) Token: 0x06009E0C RID: 40460
	EPlayPointState PlayPointState { get; set; }

	// Token: 0x170010BA RID: 4282
	// (get) Token: 0x06009E0D RID: 40461
	// (set) Token: 0x06009E0E RID: 40462
	int? PlayPointId { get; set; }

	// Token: 0x170010BB RID: 4283
	// (get) Token: 0x06009E0F RID: 40463
	// (set) Token: 0x06009E10 RID: 40464
	EPlayPointState? LastPlayPointState { get; set; }

	// Token: 0x170010BC RID: 4284
	// (get) Token: 0x06009E11 RID: 40465
	// (set) Token: 0x06009E12 RID: 40466
	int? EntityId { get; set; }

	// Token: 0x170010BD RID: 4285
	// (get) Token: 0x06009E13 RID: 40467
	// (set) Token: 0x06009E14 RID: 40468
	bool? IgnoreHiddenType { get; set; }

	// Token: 0x170010BE RID: 4286
	// (get) Token: 0x06009E15 RID: 40469
	// (set) Token: 0x06009E16 RID: 40470
	bool? IsClear { get; set; }

	// Token: 0x170010BF RID: 4287
	// (get) Token: 0x06009E17 RID: 40471
	// (set) Token: 0x06009E18 RID: 40472
	string ClearInfo { get; set; }

	// Token: 0x170010C0 RID: 4288
	// (get) Token: 0x06009E19 RID: 40473
	// (set) Token: 0x06009E1A RID: 40474
	bool? IsUnlock { get; set; }
}
