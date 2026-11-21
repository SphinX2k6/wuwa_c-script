using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F01 RID: 7937
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerRewardItemData
{
	// Token: 0x06013A3E RID: 80446 RVA: 0x005BA041 File Offset: 0x005B8241
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRewardItemData()
	{
	}

	// Token: 0x0400A7BC RID: 42940
	[RequiredMember]
	public int Id;

	// Token: 0x0400A7BD RID: 42941
	[RequiredMember]
	public string TitleKey;

	// Token: 0x0400A7BE RID: 42942
	[RequiredMember]
	public List<TItem> RewardList;

	// Token: 0x0400A7BF RID: 42943
	[RequiredMember]
	public bool IsReceive;

	// Token: 0x0400A7C0 RID: 42944
	[RequiredMember]
	public bool IsProgress;

	// Token: 0x0400A7C1 RID: 42945
	[RequiredMember]
	public bool IsCompleted;

	// Token: 0x0400A7C2 RID: 42946
	[RequiredMember]
	public int TotalScore;
}
