using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A17 RID: 2583
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestData
{
	// Token: 0x060070B9 RID: 28857 RVA: 0x00228C9A File Offset: 0x00226E9A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestData()
	{
	}

	// Token: 0x04004546 RID: 17734
	public int Id;

	// Token: 0x04004547 RID: 17735
	public EVersionPreheatQuestState State;

	// Token: 0x04004548 RID: 17736
	[RequiredMember]
	public string NumberTextId;

	// Token: 0x04004549 RID: 17737
	[RequiredMember]
	public string NumberTextArg;

	// Token: 0x0400454A RID: 17738
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x0400454B RID: 17739
	public long UnlockTimestamp;
}
