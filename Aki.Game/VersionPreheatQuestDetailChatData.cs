using System;
using System.Runtime.CompilerServices;

// Token: 0x02001569 RID: 5481
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestDetailChatData
{
	// Token: 0x06009CE5 RID: 40165 RVA: 0x0021EF3A File Offset: 0x0021D13A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestDetailChatData()
	{
	}

	// Token: 0x040044C6 RID: 17606
	[RequiredMember]
	public string NpcIconPath;

	// Token: 0x040044C7 RID: 17607
	[RequiredMember]
	public string NpcContentTextId;

	// Token: 0x040044C8 RID: 17608
	[Nullable(2)]
	public VersionPreheatQuestDetailChatData SelfChatData;
}
