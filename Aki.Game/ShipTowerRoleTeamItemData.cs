using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002984 RID: 10628
[RequiredMember]
public class ShipTowerRoleTeamItemData
{
	// Token: 0x06016036 RID: 90166 RVA: 0x0058F06D File Offset: 0x0058D26D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRoleTeamItemData()
	{
	}

	// Token: 0x0400A3C5 RID: 41925
	[Nullable(1)]
	[RequiredMember]
	public List<int> RoleIdList;

	// Token: 0x0400A3C6 RID: 41926
	[RequiredMember]
	public int Position;
}
