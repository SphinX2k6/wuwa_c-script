using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x0200297F RID: 10623
[RequiredMember]
public class ShipTowerRoleData : HaveAreaInfo
{
	// Token: 0x06016034 RID: 90164 RVA: 0x0058F05D File Offset: 0x0058D25D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRoleData()
	{
	}

	// Token: 0x0400A3B1 RID: 41905
	[RequiredMember]
	public int RoleId;

	// Token: 0x0400A3B2 RID: 41906
	[RequiredMember]
	public int RoleIdEdit;

	// Token: 0x0400A3B3 RID: 41907
	[RequiredMember]
	public int TeamIndex;

	// Token: 0x0400A3B4 RID: 41908
	[RequiredMember]
	public int TeamId;

	// Token: 0x0400A3B5 RID: 41909
	[RequiredMember]
	public int PositionIndex;

	// Token: 0x0400A3B6 RID: 41910
	public int SkillBranchId;

	// Token: 0x0400A3B7 RID: 41911
	public int SkillBranchIdEdit;
}
