using System;
using System.Runtime.CompilerServices;

// Token: 0x02001568 RID: 5480
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailVoteData
{
	// Token: 0x06009CE4 RID: 40164 RVA: 0x0021EF32 File Offset: 0x0021D132
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailVoteData()
	{
	}

	// Token: 0x040044BF RID: 17599
	public float LeftNormalized;

	// Token: 0x040044C0 RID: 17600
	public float RightNormalized;

	// Token: 0x040044C1 RID: 17601
	[RequiredMember]
	public string LeftPercentageText;

	// Token: 0x040044C2 RID: 17602
	[RequiredMember]
	public string RightPercentageText;

	// Token: 0x040044C3 RID: 17603
	[RequiredMember]
	public string LeftThemeTextId;

	// Token: 0x040044C4 RID: 17604
	[RequiredMember]
	public string RightThemeTextId;

	// Token: 0x040044C5 RID: 17605
	public bool IsLeftChosen;
}
