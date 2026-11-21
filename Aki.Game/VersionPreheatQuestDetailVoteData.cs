using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A20 RID: 2592
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailVoteData
{
	// Token: 0x060070C2 RID: 28866 RVA: 0x00228CE2 File Offset: 0x00226EE2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailVoteData()
	{
	}

	// Token: 0x04004565 RID: 17765
	public float LeftNormalized;

	// Token: 0x04004566 RID: 17766
	public float RightNormalized;

	// Token: 0x04004567 RID: 17767
	[RequiredMember]
	public string LeftPercentageText;

	// Token: 0x04004568 RID: 17768
	[RequiredMember]
	public string RightPercentageText;

	// Token: 0x04004569 RID: 17769
	[RequiredMember]
	public string LeftThemeTextId;

	// Token: 0x0400456A RID: 17770
	[RequiredMember]
	public string RightThemeTextId;

	// Token: 0x0400456B RID: 17771
	public bool IsLeftChosen;
}
