using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002986 RID: 10630
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerRewardItemData
{
	// Token: 0x06016038 RID: 90168 RVA: 0x0058F07D File Offset: 0x0058D27D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRewardItemData()
	{
	}

	// Token: 0x0400A3D2 RID: 41938
	[RequiredMember]
	public int Id;

	// Token: 0x0400A3D3 RID: 41939
	[RequiredMember]
	public string TitleKey;

	// Token: 0x0400A3D4 RID: 41940
	[RequiredMember]
	public List<TItem> RewardList;

	// Token: 0x0400A3D5 RID: 41941
	[RequiredMember]
	public bool IsReceive;

	// Token: 0x0400A3D6 RID: 41942
	[RequiredMember]
	public bool IsProgress;

	// Token: 0x0400A3D7 RID: 41943
	[RequiredMember]
	public bool IsCompleted;

	// Token: 0x0400A3D8 RID: 41944
	[RequiredMember]
	public int TotalScore;
}
