using System;

// Token: 0x02001658 RID: 5720
public interface IConflictInfo
{
	// Token: 0x17000D8F RID: 3471
	// (get) Token: 0x0600A0D2 RID: 41170
	// (set) Token: 0x0600A0D3 RID: 41171
	int RoleId { get; set; }

	// Token: 0x17000D90 RID: 3472
	// (get) Token: 0x0600A0D4 RID: 41172
	// (set) Token: 0x0600A0D5 RID: 41173
	bool WeaponConflict { get; set; }

	// Token: 0x17000D91 RID: 3473
	// (get) Token: 0x0600A0D6 RID: 41174
	// (set) Token: 0x0600A0D7 RID: 41175
	bool PhantomConflict { get; set; }
}
