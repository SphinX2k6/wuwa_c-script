using System;
using System.Runtime.CompilerServices;

// Token: 0x02001567 RID: 5479
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailPersistentData
{
	// Token: 0x06009CE3 RID: 40163 RVA: 0x0021EF2A File Offset: 0x0021D12A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailPersistentData()
	{
	}

	// Token: 0x040044B8 RID: 17592
	public int Index;

	// Token: 0x040044B9 RID: 17593
	[RequiredMember]
	public string QuestPhotoPath;

	// Token: 0x040044BA RID: 17594
	[RequiredMember]
	public string QuestTitleTextId;

	// Token: 0x040044BB RID: 17595
	[RequiredMember]
	public string QuestContentTextId;

	// Token: 0x040044BC RID: 17596
	public int QuestCrestIndex;

	// Token: 0x040044BD RID: 17597
	[RequiredMember]
	public string QuestSharePhotoPath;

	// Token: 0x040044BE RID: 17598
	public bool CanShare;
}
