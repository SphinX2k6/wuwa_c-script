using System;

// Token: 0x02000F47 RID: 3911
public class DrinksMixRoleInfo : IDrinksMixRoleInfo
{
	// Token: 0x170007AB RID: 1963
	// (get) Token: 0x060063A7 RID: 25511 RVA: 0x00139AE2 File Offset: 0x00137CE2
	// (set) Token: 0x060063A8 RID: 25512 RVA: 0x00139AEA File Offset: 0x00137CEA
	public int RoleId { get; set; }

	// Token: 0x170007AC RID: 1964
	// (get) Token: 0x060063A9 RID: 25513 RVA: 0x00139AF3 File Offset: 0x00137CF3
	// (set) Token: 0x060063AA RID: 25514 RVA: 0x00139AFB File Offset: 0x00137CFB
	public bool FirstPass { get; set; }

	// Token: 0x170007AD RID: 1965
	// (get) Token: 0x060063AB RID: 25515 RVA: 0x00139B04 File Offset: 0x00137D04
	// (set) Token: 0x060063AC RID: 25516 RVA: 0x00139B0C File Offset: 0x00137D0C
	public bool MaxLike { get; set; }

	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x060063AD RID: 25517 RVA: 0x00139B15 File Offset: 0x00137D15
	// (set) Token: 0x060063AE RID: 25518 RVA: 0x00139B1D File Offset: 0x00137D1D
	public bool RewardGet { get; set; }
}
