using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001516 RID: 5398
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class Spring25LetterListViewData
{
	// Token: 0x06009A07 RID: 39431 RVA: 0x0021544B File Offset: 0x0021364B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25LetterListViewData()
	{
	}

	// Token: 0x040043B9 RID: 17337
	[Nullable(1)]
	[RequiredMember]
	public List<Spring25LetterListTabData> TabDataList;

	// Token: 0x040043BA RID: 17338
	public string InfoTextId;

	// Token: 0x040043BB RID: 17339
	public string TitleTextId;
}
