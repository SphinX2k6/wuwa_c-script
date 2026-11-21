using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A1F RID: 2591
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailPersistentData
{
	// Token: 0x060070C1 RID: 28865 RVA: 0x00228CDA File Offset: 0x00226EDA
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailPersistentData()
	{
	}

	// Token: 0x0400455E RID: 17758
	public int Index;

	// Token: 0x0400455F RID: 17759
	[RequiredMember]
	public string QuestPhotoPath;

	// Token: 0x04004560 RID: 17760
	[RequiredMember]
	public string QuestTitleTextId;

	// Token: 0x04004561 RID: 17761
	[RequiredMember]
	public string QuestContentTextId;

	// Token: 0x04004562 RID: 17762
	public int QuestCrestIndex;

	// Token: 0x04004563 RID: 17763
	[RequiredMember]
	public string QuestSharePhotoPath;

	// Token: 0x04004564 RID: 17764
	public bool CanShare;
}
