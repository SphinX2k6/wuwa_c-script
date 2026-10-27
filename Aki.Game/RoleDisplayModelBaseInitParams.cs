using System;
using System.Runtime.CompilerServices;

// Token: 0x020027D3 RID: 10195
[NullableContext(1)]
[Nullable(0)]
public class RoleDisplayModelBaseInitParams
{
	// Token: 0x17001B4F RID: 6991
	// (get) Token: 0x06014F2F RID: 85807 RVA: 0x00550E05 File Offset: 0x0054F005
	// (set) Token: 0x06014F30 RID: 85808 RVA: 0x00550E0D File Offset: 0x0054F00D
	public int Id { get; set; }

	// Token: 0x17001B50 RID: 6992
	// (get) Token: 0x06014F31 RID: 85809 RVA: 0x00550E16 File Offset: 0x0054F016
	// (set) Token: 0x06014F32 RID: 85810 RVA: 0x00550E1E File Offset: 0x0054F01E
	public string Name { get; set; }

	// Token: 0x17001B51 RID: 6993
	// (get) Token: 0x06014F33 RID: 85811 RVA: 0x00550E27 File Offset: 0x0054F027
	// (set) Token: 0x06014F34 RID: 85812 RVA: 0x00550E2F File Offset: 0x0054F02F
	public int SkinId { get; set; }

	// Token: 0x17001B52 RID: 6994
	// (get) Token: 0x06014F35 RID: 85813 RVA: 0x00550E38 File Offset: 0x0054F038
	// (set) Token: 0x06014F36 RID: 85814 RVA: 0x00550E40 File Offset: 0x0054F040
	public int ElementId { get; set; }

	// Token: 0x17001B53 RID: 6995
	// (get) Token: 0x06014F37 RID: 85815 RVA: 0x00550E49 File Offset: 0x0054F049
	// (set) Token: 0x06014F38 RID: 85816 RVA: 0x00550E51 File Offset: 0x0054F051
	public int Level { get; set; }

	// Token: 0x17001B54 RID: 6996
	// (get) Token: 0x06014F39 RID: 85817 RVA: 0x00550E5A File Offset: 0x0054F05A
	// (set) Token: 0x06014F3A RID: 85818 RVA: 0x00550E62 File Offset: 0x0054F062
	public bool IsInTeam { get; set; }

	// Token: 0x17001B55 RID: 6997
	// (get) Token: 0x06014F3B RID: 85819 RVA: 0x00550E6B File Offset: 0x0054F06B
	// (set) Token: 0x06014F3C RID: 85820 RVA: 0x00550E73 File Offset: 0x0054F073
	public bool IsTrial { get; set; }

	// Token: 0x17001B56 RID: 6998
	// (get) Token: 0x06014F3D RID: 85821 RVA: 0x00550E7C File Offset: 0x0054F07C
	// (set) Token: 0x06014F3E RID: 85822 RVA: 0x00550E84 File Offset: 0x0054F084
	public bool IsNew { get; set; }

	// Token: 0x17001B57 RID: 6999
	// (get) Token: 0x06014F3F RID: 85823 RVA: 0x00550E8D File Offset: 0x0054F08D
	// (set) Token: 0x06014F40 RID: 85824 RVA: 0x00550E95 File Offset: 0x0054F095
	public ERoleTypeTag TypeTag { get; set; }
}
