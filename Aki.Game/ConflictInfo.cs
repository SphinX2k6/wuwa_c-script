using System;

// Token: 0x02000B11 RID: 2833
public class ConflictInfo : IConflictInfo
{
	// Token: 0x17000DB3 RID: 3507
	// (get) Token: 0x060074B6 RID: 29878 RVA: 0x00241501 File Offset: 0x0023F701
	// (set) Token: 0x060074B7 RID: 29879 RVA: 0x00241509 File Offset: 0x0023F709
	public int RoleId { get; set; }

	// Token: 0x17000DB4 RID: 3508
	// (get) Token: 0x060074B8 RID: 29880 RVA: 0x00241512 File Offset: 0x0023F712
	// (set) Token: 0x060074B9 RID: 29881 RVA: 0x0024151A File Offset: 0x0023F71A
	public bool WeaponConflict { get; set; }

	// Token: 0x17000DB5 RID: 3509
	// (get) Token: 0x060074BA RID: 29882 RVA: 0x00241523 File Offset: 0x0023F723
	// (set) Token: 0x060074BB RID: 29883 RVA: 0x0024152B File Offset: 0x0023F72B
	public bool PhantomConflict { get; set; }
}
