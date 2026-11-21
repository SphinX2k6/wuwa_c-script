using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F00 RID: 7936
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerAreaItemData
{
	// Token: 0x06013A3D RID: 80445 RVA: 0x005BA039 File Offset: 0x005B8239
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerAreaItemData()
	{
	}

	// Token: 0x0400A7B1 RID: 42929
	[RequiredMember]
	public int Id;

	// Token: 0x0400A7B2 RID: 42930
	public int? Index;

	// Token: 0x0400A7B3 RID: 42931
	[RequiredMember]
	public string Name;

	// Token: 0x0400A7B4 RID: 42932
	[RequiredMember]
	public string Desc;

	// Token: 0x0400A7B5 RID: 42933
	[Nullable(2)]
	public string TimeContent;

	// Token: 0x0400A7B6 RID: 42934
	public bool? IsFinish;

	// Token: 0x0400A7B7 RID: 42935
	public bool? IsRedPoint;

	// Token: 0x0400A7B8 RID: 42936
	public bool? IsEndless;

	// Token: 0x0400A7B9 RID: 42937
	public int? MaxScore;

	// Token: 0x0400A7BA RID: 42938
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ShipTowerRewardItemData> RewardList;

	// Token: 0x0400A7BB RID: 42939
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ShipTowerRecordItemData> RecordList;
}
