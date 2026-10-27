using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200156C RID: 5484
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatVoteData
{
	// Token: 0x06009CE8 RID: 40168 RVA: 0x0021EF52 File Offset: 0x0021D152
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatVoteData()
	{
	}

	// Token: 0x040044D3 RID: 17619
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x040044D4 RID: 17620
	[RequiredMember]
	public string ContentTextId;

	// Token: 0x040044D5 RID: 17621
	public int CrestIndex;

	// Token: 0x040044D6 RID: 17622
	[RequiredMember]
	public VersionPreheatVoteToggleData LeftToggleData;

	// Token: 0x040044D7 RID: 17623
	[RequiredMember]
	public VersionPreheatVoteToggleData RightToggleData;

	// Token: 0x040044D8 RID: 17624
	[RequiredMember]
	public List<TItem> ItemListData;

	// Token: 0x040044D9 RID: 17625
	public bool? IsLeftChosen;
}
