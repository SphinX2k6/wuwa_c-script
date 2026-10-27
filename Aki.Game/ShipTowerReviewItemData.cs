using System;
using System.Runtime.CompilerServices;

// Token: 0x02002991 RID: 10641
[RequiredMember]
public class ShipTowerReviewItemData
{
	// Token: 0x06016043 RID: 90179 RVA: 0x0058F0D5 File Offset: 0x0058D2D5
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerReviewItemData()
	{
	}

	// Token: 0x0400A3FD RID: 41981
	[Nullable(1)]
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3FE RID: 41982
	[RequiredMember]
	public int Score;

	// Token: 0x0400A3FF RID: 41983
	[Nullable(2)]
	public string Grade;

	// Token: 0x0400A400 RID: 41984
	[RequiredMember]
	public int StageId;

	// Token: 0x0400A401 RID: 41985
	[RequiredMember]
	public bool IsQuickPass;
}
