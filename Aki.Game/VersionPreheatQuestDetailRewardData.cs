using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200156A RID: 5482
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailRewardData
{
	// Token: 0x06009CE6 RID: 40166 RVA: 0x0021EF42 File Offset: 0x0021D142
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailRewardData()
	{
	}

	// Token: 0x040044C9 RID: 17609
	[RequiredMember]
	public string QuestContentTextId;

	// Token: 0x040044CA RID: 17610
	[RequiredMember]
	public List<TItem> ItemListData;

	// Token: 0x040044CB RID: 17611
	public bool IsReceived;

	// Token: 0x040044CC RID: 17612
	[RequiredMember]
	public TVersionPreheatQuestDetailClickFunc ClickFunc;

	// Token: 0x040044CD RID: 17613
	public int ClickPassData;
}
