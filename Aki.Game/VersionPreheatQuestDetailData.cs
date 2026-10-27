using System;
using System.Runtime.CompilerServices;

// Token: 0x02001566 RID: 5478
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailData
{
	// Token: 0x06009CE2 RID: 40162 RVA: 0x0021EF22 File Offset: 0x0021D122
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailData()
	{
	}

	// Token: 0x040044B3 RID: 17587
	[Nullable(1)]
	[RequiredMember]
	public VersionPreheatQuestDetailPersistentData PersistentData;

	// Token: 0x040044B4 RID: 17588
	public VersionPreheatQuestDetailVoteData VoteData;

	// Token: 0x040044B5 RID: 17589
	public VersionPreheatQuestDetailChatData ChatData;

	// Token: 0x040044B6 RID: 17590
	public VersionPreheatQuestDetailRewardData RewardData;

	// Token: 0x040044B7 RID: 17591
	public string BonusTextId;
}
