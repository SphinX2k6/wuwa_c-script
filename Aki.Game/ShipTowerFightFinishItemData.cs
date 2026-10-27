using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002992 RID: 10642
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerFightFinishItemData
{
	// Token: 0x06016044 RID: 90180 RVA: 0x0058F0DD File Offset: 0x0058D2DD
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerFightFinishItemData()
	{
	}

	// Token: 0x0400A402 RID: 41986
	[RequiredMember]
	public string TotalTitle;

	// Token: 0x0400A403 RID: 41987
	[RequiredMember]
	public string TitleA;

	// Token: 0x0400A404 RID: 41988
	[RequiredMember]
	public string TitleB;

	// Token: 0x0400A405 RID: 41989
	[RequiredMember]
	public int ScoreA;

	// Token: 0x0400A406 RID: 41990
	[RequiredMember]
	public int ScoreB;

	// Token: 0x0400A407 RID: 41991
	[RequiredMember]
	public List<ShipTowerMediumItemData> RoleList;

	// Token: 0x0400A408 RID: 41992
	[RequiredMember]
	public int BuffId;
}
