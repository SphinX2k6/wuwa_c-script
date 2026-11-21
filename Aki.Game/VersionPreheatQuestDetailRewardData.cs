using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000A22 RID: 2594
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailRewardData
{
	// Token: 0x060070C4 RID: 28868 RVA: 0x00228CF2 File Offset: 0x00226EF2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailRewardData()
	{
	}

	// Token: 0x0400456F RID: 17775
	[RequiredMember]
	public string QuestContentTextId;

	// Token: 0x04004570 RID: 17776
	[RequiredMember]
	public List<TItem> ItemListData;

	// Token: 0x04004571 RID: 17777
	public bool IsReceived;

	// Token: 0x04004572 RID: 17778
	[RequiredMember]
	public TVersionPreheatQuestDetailClickFunc ClickFunc;

	// Token: 0x04004573 RID: 17779
	public int ClickPassData;
}
