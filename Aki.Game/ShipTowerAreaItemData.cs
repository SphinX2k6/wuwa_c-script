using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002985 RID: 10629
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerAreaItemData
{
	// Token: 0x06016037 RID: 90167 RVA: 0x0058F075 File Offset: 0x0058D275
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerAreaItemData()
	{
	}

	// Token: 0x0400A3C7 RID: 41927
	[RequiredMember]
	public int Id;

	// Token: 0x0400A3C8 RID: 41928
	public int? Index;

	// Token: 0x0400A3C9 RID: 41929
	[RequiredMember]
	public string Name;

	// Token: 0x0400A3CA RID: 41930
	[RequiredMember]
	public string Desc;

	// Token: 0x0400A3CB RID: 41931
	[Nullable(2)]
	public string TimeContent;

	// Token: 0x0400A3CC RID: 41932
	public bool? IsFinish;

	// Token: 0x0400A3CD RID: 41933
	public bool? IsRedPoint;

	// Token: 0x0400A3CE RID: 41934
	public bool? IsEndless;

	// Token: 0x0400A3CF RID: 41935
	public int? MaxScore;

	// Token: 0x0400A3D0 RID: 41936
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ShipTowerRewardItemData> RewardList;

	// Token: 0x0400A3D1 RID: 41937
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ShipTowerRecordItemData> RecordList;
}
