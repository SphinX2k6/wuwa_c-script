using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001519 RID: 5401
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25InfoViewData
{
	// Token: 0x06009A0A RID: 39434 RVA: 0x00215463 File Offset: 0x00213663
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25InfoViewData()
	{
	}

	// Token: 0x040043C7 RID: 17351
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x040043C8 RID: 17352
	[RequiredMember]
	public string CurrentNum;

	// Token: 0x040043C9 RID: 17353
	[RequiredMember]
	public string TotalNumTextId;

	// Token: 0x040043CA RID: 17354
	[RequiredMember]
	public string TotalNumTextArg;

	// Token: 0x040043CB RID: 17355
	[RequiredMember]
	public ESpring25InfoBottomState BottomState;

	// Token: 0x040043CC RID: 17356
	[RequiredMember]
	public List<Spring25InfoContentData> ContentList;

	// Token: 0x040043CD RID: 17357
	[RequiredMember]
	public List<Spring25InfoProgressData> ProgressList;
}
