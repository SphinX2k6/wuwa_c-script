using System;

// Token: 0x02000F46 RID: 3910
public interface IDrinksMixRoleInfo
{
	// Token: 0x170007A7 RID: 1959
	// (get) Token: 0x0600639F RID: 25503
	// (set) Token: 0x060063A0 RID: 25504
	int RoleId { get; set; }

	// Token: 0x170007A8 RID: 1960
	// (get) Token: 0x060063A1 RID: 25505
	// (set) Token: 0x060063A2 RID: 25506
	bool FirstPass { get; set; }

	// Token: 0x170007A9 RID: 1961
	// (get) Token: 0x060063A3 RID: 25507
	// (set) Token: 0x060063A4 RID: 25508
	bool MaxLike { get; set; }

	// Token: 0x170007AA RID: 1962
	// (get) Token: 0x060063A5 RID: 25509
	// (set) Token: 0x060063A6 RID: 25510
	bool RewardGet { get; set; }
}
