using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009D1 RID: 2513
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25InfoViewData
{
	// Token: 0x06006DE8 RID: 28136 RVA: 0x0021F1FF File Offset: 0x0021D3FF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25InfoViewData()
	{
	}

	// Token: 0x0400446D RID: 17517
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x0400446E RID: 17518
	[RequiredMember]
	public string CurrentNum;

	// Token: 0x0400446F RID: 17519
	[RequiredMember]
	public string TotalNumTextId;

	// Token: 0x04004470 RID: 17520
	[RequiredMember]
	public string TotalNumTextArg;

	// Token: 0x04004471 RID: 17521
	[RequiredMember]
	public ESpring25InfoBottomState BottomState;

	// Token: 0x04004472 RID: 17522
	[RequiredMember]
	public List<Spring25InfoContentData> ContentList;

	// Token: 0x04004473 RID: 17523
	[RequiredMember]
	public List<Spring25InfoProgressData> ProgressList;
}
