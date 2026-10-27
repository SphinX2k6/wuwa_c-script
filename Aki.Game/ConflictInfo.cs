using System;

// Token: 0x02001659 RID: 5721
public class ConflictInfo : IConflictInfo
{
	// Token: 0x17000D92 RID: 3474
	// (get) Token: 0x0600A0D8 RID: 41176 RVA: 0x00237665 File Offset: 0x00235865
	// (set) Token: 0x0600A0D9 RID: 41177 RVA: 0x0023766D File Offset: 0x0023586D
	public int RoleId { get; set; }

	// Token: 0x17000D93 RID: 3475
	// (get) Token: 0x0600A0DA RID: 41178 RVA: 0x00237676 File Offset: 0x00235876
	// (set) Token: 0x0600A0DB RID: 41179 RVA: 0x0023767E File Offset: 0x0023587E
	public bool WeaponConflict { get; set; }

	// Token: 0x17000D94 RID: 3476
	// (get) Token: 0x0600A0DC RID: 41180 RVA: 0x00237687 File Offset: 0x00235887
	// (set) Token: 0x0600A0DD RID: 41181 RVA: 0x0023768F File Offset: 0x0023588F
	public bool PhantomConflict { get; set; }
}
