using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A25 RID: 2597
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatVoteToggleData
{
	// Token: 0x060070C7 RID: 28871 RVA: 0x00228D0A File Offset: 0x00226F0A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatVoteToggleData()
	{
	}

	// Token: 0x04004580 RID: 17792
	public int Id;

	// Token: 0x04004581 RID: 17793
	[RequiredMember]
	public string ContentTextId;

	// Token: 0x04004582 RID: 17794
	[RequiredMember]
	public TVersionPreheatVoteClickFunc ClickFunc;

	// Token: 0x04004583 RID: 17795
	public bool ClickPassData;
}
