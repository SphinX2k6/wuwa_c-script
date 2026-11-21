using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A21 RID: 2593
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailChatData
{
	// Token: 0x060070C3 RID: 28867 RVA: 0x00228CEA File Offset: 0x00226EEA
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailChatData()
	{
	}

	// Token: 0x0400456C RID: 17772
	[RequiredMember]
	public string NpcIconPath;

	// Token: 0x0400456D RID: 17773
	[RequiredMember]
	public string NpcContentTextId;

	// Token: 0x0400456E RID: 17774
	[Nullable(2)]
	public VersionPreheatQuestDetailChatData SelfChatData;
}
