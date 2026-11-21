using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001EFA RID: 7930
[RequiredMember]
public class ShipTowerRoleData : HaveAreaInfo
{
	// Token: 0x06013A3A RID: 80442 RVA: 0x005BA021 File Offset: 0x005B8221
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRoleData()
	{
	}

	// Token: 0x0400A79B RID: 42907
	[RequiredMember]
	public int RoleId;

	// Token: 0x0400A79C RID: 42908
	[RequiredMember]
	public int RoleIdEdit;

	// Token: 0x0400A79D RID: 42909
	[RequiredMember]
	public int TeamIndex;

	// Token: 0x0400A79E RID: 42910
	[RequiredMember]
	public int TeamId;

	// Token: 0x0400A79F RID: 42911
	[RequiredMember]
	public int PositionIndex;

	// Token: 0x0400A7A0 RID: 42912
	public int SkillBranchId;

	// Token: 0x0400A7A1 RID: 42913
	public int SkillBranchIdEdit;
}
