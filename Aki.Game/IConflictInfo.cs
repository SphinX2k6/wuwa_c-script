using System;

// Token: 0x02000B10 RID: 2832
public interface IConflictInfo
{
	// Token: 0x17000DB0 RID: 3504
	// (get) Token: 0x060074B0 RID: 29872
	// (set) Token: 0x060074B1 RID: 29873
	int RoleId { get; set; }

	// Token: 0x17000DB1 RID: 3505
	// (get) Token: 0x060074B2 RID: 29874
	// (set) Token: 0x060074B3 RID: 29875
	bool WeaponConflict { get; set; }

	// Token: 0x17000DB2 RID: 3506
	// (get) Token: 0x060074B4 RID: 29876
	// (set) Token: 0x060074B5 RID: 29877
	bool PhantomConflict { get; set; }
}
