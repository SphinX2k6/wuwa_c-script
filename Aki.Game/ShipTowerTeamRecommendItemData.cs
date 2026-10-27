using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002989 RID: 10633
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerTeamRecommendItemData
{
	// Token: 0x0601603B RID: 90171 RVA: 0x0058F095 File Offset: 0x0058D295
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerTeamRecommendItemData()
	{
	}

	// Token: 0x0400A3DE RID: 41950
	[RequiredMember]
	public List<ShipTowerMediumItemData> RoleIdList1;

	// Token: 0x0400A3DF RID: 41951
	[RequiredMember]
	public List<ShipTowerMediumItemData> RoleIdList2;

	// Token: 0x0400A3E0 RID: 41952
	[RequiredMember]
	public int Buff1;

	// Token: 0x0400A3E1 RID: 41953
	[RequiredMember]
	public int Buff2;

	// Token: 0x0400A3E2 RID: 41954
	[RequiredMember]
	public int UseRate;

	// Token: 0x0400A3E3 RID: 41955
	[RequiredMember]
	public string Name;

	// Token: 0x0400A3E4 RID: 41956
	[Nullable(2)]
	public ShipTowerStageData StageData;
}
