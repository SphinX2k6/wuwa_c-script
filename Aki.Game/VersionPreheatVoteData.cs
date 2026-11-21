using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000A24 RID: 2596
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatVoteData
{
	// Token: 0x060070C6 RID: 28870 RVA: 0x00228D02 File Offset: 0x00226F02
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatVoteData()
	{
	}

	// Token: 0x04004579 RID: 17785
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x0400457A RID: 17786
	[RequiredMember]
	public string ContentTextId;

	// Token: 0x0400457B RID: 17787
	public int CrestIndex;

	// Token: 0x0400457C RID: 17788
	[RequiredMember]
	public VersionPreheatVoteToggleData LeftToggleData;

	// Token: 0x0400457D RID: 17789
	[RequiredMember]
	public VersionPreheatVoteToggleData RightToggleData;

	// Token: 0x0400457E RID: 17790
	[RequiredMember]
	public List<TItem> ItemListData;

	// Token: 0x0400457F RID: 17791
	public bool? IsLeftChosen;
}
