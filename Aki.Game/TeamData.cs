using System;
using System.Runtime.CompilerServices;

// Token: 0x0200083A RID: 2106
[NullableContext(2)]
[Nullable(0)]
internal class TeamData
{
	// Token: 0x04003EB0 RID: 16048
	public int RoleId;

	// Token: 0x04003EB1 RID: 16049
	public MowingTowerTeamInfo TeamInfo;

	// Token: 0x04003EB2 RID: 16050
	public ETeamBelong BelongTo;

	// Token: 0x04003EB3 RID: 16051
	public Action OnSelectRole;
}
