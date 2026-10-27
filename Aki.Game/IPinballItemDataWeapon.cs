using System;

// Token: 0x02001406 RID: 5126
public interface IPinballItemDataWeapon
{
	// Token: 0x17000C4C RID: 3148
	// (get) Token: 0x060090D8 RID: 37080
	// (set) Token: 0x060090D9 RID: 37081
	EPinballItemType Type { get; set; }

	// Token: 0x17000C4D RID: 3149
	// (get) Token: 0x060090DA RID: 37082
	// (set) Token: 0x060090DB RID: 37083
	int Id { get; set; }

	// Token: 0x17000C4E RID: 3150
	// (get) Token: 0x060090DC RID: 37084
	// (set) Token: 0x060090DD RID: 37085
	int IncId { get; set; }

	// Token: 0x17000C4F RID: 3151
	// (get) Token: 0x060090DE RID: 37086
	// (set) Token: 0x060090DF RID: 37087
	bool? IsUnavailable { get; set; }

	// Token: 0x17000C50 RID: 3152
	// (get) Token: 0x060090E0 RID: 37088
	// (set) Token: 0x060090E1 RID: 37089
	int? RoleId { get; set; }

	// Token: 0x17000C51 RID: 3153
	// (get) Token: 0x060090E2 RID: 37090
	// (set) Token: 0x060090E3 RID: 37091
	bool? IsLocked { get; set; }

	// Token: 0x17000C52 RID: 3154
	// (get) Token: 0x060090E4 RID: 37092
	// (set) Token: 0x060090E5 RID: 37093
	bool? NeedReduceBtn { get; set; }

	// Token: 0x17000C53 RID: 3155
	// (get) Token: 0x060090E6 RID: 37094
	// (set) Token: 0x060090E7 RID: 37095
	bool? IsRecommendedWeapon { get; set; }
}
