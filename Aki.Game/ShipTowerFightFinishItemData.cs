using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F0D RID: 7949
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerFightFinishItemData
{
	// Token: 0x06013A4A RID: 80458 RVA: 0x005BA0A1 File Offset: 0x005B82A1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerFightFinishItemData()
	{
	}

	// Token: 0x0400A7EC RID: 42988
	[RequiredMember]
	public string TotalTitle;

	// Token: 0x0400A7ED RID: 42989
	[RequiredMember]
	public string TitleA;

	// Token: 0x0400A7EE RID: 42990
	[RequiredMember]
	public string TitleB;

	// Token: 0x0400A7EF RID: 42991
	[RequiredMember]
	public int ScoreA;

	// Token: 0x0400A7F0 RID: 42992
	[RequiredMember]
	public int ScoreB;

	// Token: 0x0400A7F1 RID: 42993
	[RequiredMember]
	public List<ShipTowerMediumItemData> RoleList;

	// Token: 0x0400A7F2 RID: 42994
	[RequiredMember]
	public int BuffId;
}
