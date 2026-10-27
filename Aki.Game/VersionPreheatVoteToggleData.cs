using System;
using System.Runtime.CompilerServices;

// Token: 0x0200156D RID: 5485
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatVoteToggleData
{
	// Token: 0x06009CE9 RID: 40169 RVA: 0x0021EF5A File Offset: 0x0021D15A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatVoteToggleData()
	{
	}

	// Token: 0x040044DA RID: 17626
	public int Id;

	// Token: 0x040044DB RID: 17627
	[RequiredMember]
	public string ContentTextId;

	// Token: 0x040044DC RID: 17628
	[RequiredMember]
	public TVersionPreheatVoteClickFunc ClickFunc;

	// Token: 0x040044DD RID: 17629
	public bool ClickPassData;
}
