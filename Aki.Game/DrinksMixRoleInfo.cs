using System;

// Token: 0x020003FC RID: 1020
public class DrinksMixRoleInfo : IDrinksMixRoleInfo
{
	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x0600373F RID: 14143 RVA: 0x001423AE File Offset: 0x001405AE
	// (set) Token: 0x06003740 RID: 14144 RVA: 0x001423B6 File Offset: 0x001405B6
	public int RoleId { get; set; }

	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x06003741 RID: 14145 RVA: 0x001423BF File Offset: 0x001405BF
	// (set) Token: 0x06003742 RID: 14146 RVA: 0x001423C7 File Offset: 0x001405C7
	public bool FirstPass { get; set; }

	// Token: 0x170007CF RID: 1999
	// (get) Token: 0x06003743 RID: 14147 RVA: 0x001423D0 File Offset: 0x001405D0
	// (set) Token: 0x06003744 RID: 14148 RVA: 0x001423D8 File Offset: 0x001405D8
	public bool MaxLike { get; set; }

	// Token: 0x170007D0 RID: 2000
	// (get) Token: 0x06003745 RID: 14149 RVA: 0x001423E1 File Offset: 0x001405E1
	// (set) Token: 0x06003746 RID: 14150 RVA: 0x001423E9 File Offset: 0x001405E9
	public bool RewardGet { get; set; }
}
