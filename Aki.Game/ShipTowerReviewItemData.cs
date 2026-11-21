using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F0C RID: 7948
[RequiredMember]
public class ShipTowerReviewItemData
{
	// Token: 0x06013A49 RID: 80457 RVA: 0x005BA099 File Offset: 0x005B8299
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerReviewItemData()
	{
	}

	// Token: 0x0400A7E7 RID: 42983
	[Nullable(1)]
	[RequiredMember]
	public string Title;

	// Token: 0x0400A7E8 RID: 42984
	[RequiredMember]
	public int Score;

	// Token: 0x0400A7E9 RID: 42985
	[Nullable(2)]
	public string Grade;

	// Token: 0x0400A7EA RID: 42986
	[RequiredMember]
	public int StageId;

	// Token: 0x0400A7EB RID: 42987
	[RequiredMember]
	public bool IsQuickPass;
}
