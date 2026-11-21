using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A1E RID: 2590
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailData
{
	// Token: 0x060070C0 RID: 28864 RVA: 0x00228CD2 File Offset: 0x00226ED2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailData()
	{
	}

	// Token: 0x04004559 RID: 17753
	[Nullable(1)]
	[RequiredMember]
	public VersionPreheatQuestDetailPersistentData PersistentData;

	// Token: 0x0400455A RID: 17754
	public VersionPreheatQuestDetailVoteData VoteData;

	// Token: 0x0400455B RID: 17755
	public VersionPreheatQuestDetailChatData ChatData;

	// Token: 0x0400455C RID: 17756
	public VersionPreheatQuestDetailRewardData RewardData;

	// Token: 0x0400455D RID: 17757
	public string BonusTextId;
}
