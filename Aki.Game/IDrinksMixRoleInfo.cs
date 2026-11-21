using System;

// Token: 0x020003FB RID: 1019
public interface IDrinksMixRoleInfo
{
	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x06003737 RID: 14135
	// (set) Token: 0x06003738 RID: 14136
	int RoleId { get; set; }

	// Token: 0x170007CA RID: 1994
	// (get) Token: 0x06003739 RID: 14137
	// (set) Token: 0x0600373A RID: 14138
	bool FirstPass { get; set; }

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x0600373B RID: 14139
	// (set) Token: 0x0600373C RID: 14140
	bool MaxLike { get; set; }

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x0600373D RID: 14141
	// (set) Token: 0x0600373E RID: 14142
	bool RewardGet { get; set; }
}
