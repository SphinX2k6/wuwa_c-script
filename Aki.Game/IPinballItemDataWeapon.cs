using System;

// Token: 0x020008BA RID: 2234
public interface IPinballItemDataWeapon
{
	// Token: 0x17000C6C RID: 3180
	// (get) Token: 0x0600646D RID: 25709
	// (set) Token: 0x0600646E RID: 25710
	EPinballItemType Type { get; set; }

	// Token: 0x17000C6D RID: 3181
	// (get) Token: 0x0600646F RID: 25711
	// (set) Token: 0x06006470 RID: 25712
	int Id { get; set; }

	// Token: 0x17000C6E RID: 3182
	// (get) Token: 0x06006471 RID: 25713
	// (set) Token: 0x06006472 RID: 25714
	int IncId { get; set; }

	// Token: 0x17000C6F RID: 3183
	// (get) Token: 0x06006473 RID: 25715
	// (set) Token: 0x06006474 RID: 25716
	bool? IsUnavailable { get; set; }

	// Token: 0x17000C70 RID: 3184
	// (get) Token: 0x06006475 RID: 25717
	// (set) Token: 0x06006476 RID: 25718
	int? RoleId { get; set; }

	// Token: 0x17000C71 RID: 3185
	// (get) Token: 0x06006477 RID: 25719
	// (set) Token: 0x06006478 RID: 25720
	bool? IsLocked { get; set; }

	// Token: 0x17000C72 RID: 3186
	// (get) Token: 0x06006479 RID: 25721
	// (set) Token: 0x0600647A RID: 25722
	bool? NeedReduceBtn { get; set; }

	// Token: 0x17000C73 RID: 3187
	// (get) Token: 0x0600647B RID: 25723
	// (set) Token: 0x0600647C RID: 25724
	bool? IsRecommendedWeapon { get; set; }
}
