using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F04 RID: 7940
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerTeamRecommendItemData
{
	// Token: 0x06013A41 RID: 80449 RVA: 0x005BA059 File Offset: 0x005B8259
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerTeamRecommendItemData()
	{
	}

	// Token: 0x0400A7C8 RID: 42952
	[RequiredMember]
	public List<ShipTowerMediumItemData> RoleIdList1;

	// Token: 0x0400A7C9 RID: 42953
	[RequiredMember]
	public List<ShipTowerMediumItemData> RoleIdList2;

	// Token: 0x0400A7CA RID: 42954
	[RequiredMember]
	public int Buff1;

	// Token: 0x0400A7CB RID: 42955
	[RequiredMember]
	public int Buff2;

	// Token: 0x0400A7CC RID: 42956
	[RequiredMember]
	public int UseRate;

	// Token: 0x0400A7CD RID: 42957
	[RequiredMember]
	public string Name;

	// Token: 0x0400A7CE RID: 42958
	[Nullable(2)]
	public ShipTowerStageData StageData;
}
