using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009CE RID: 2510
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class Spring25LetterListViewData
{
	// Token: 0x06006DE5 RID: 28133 RVA: 0x0021F1E7 File Offset: 0x0021D3E7
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25LetterListViewData()
	{
	}

	// Token: 0x0400445F RID: 17503
	[Nullable(1)]
	[RequiredMember]
	public List<Spring25LetterListTabData> TabDataList;

	// Token: 0x04004460 RID: 17504
	public string InfoTextId;

	// Token: 0x04004461 RID: 17505
	public string TitleTextId;
}
