using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001EFF RID: 7935
[RequiredMember]
public class ShipTowerRoleTeamItemData
{
	// Token: 0x06013A3C RID: 80444 RVA: 0x005BA031 File Offset: 0x005B8231
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRoleTeamItemData()
	{
	}

	// Token: 0x0400A7AF RID: 42927
	[Nullable(1)]
	[RequiredMember]
	public List<int> RoleIdList;

	// Token: 0x0400A7B0 RID: 42928
	[RequiredMember]
	public int Position;
}
