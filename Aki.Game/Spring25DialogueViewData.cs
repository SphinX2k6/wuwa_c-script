using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009CB RID: 2507
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25DialogueViewData
{
	// Token: 0x06006DE2 RID: 28130 RVA: 0x0021F1CF File Offset: 0x0021D3CF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25DialogueViewData()
	{
	}

	// Token: 0x04004454 RID: 17492
	[RequiredMember]
	public bool IsOpening;

	// Token: 0x04004455 RID: 17493
	[RequiredMember]
	public Spring25DialogueSpineData LeftSpineData;

	// Token: 0x04004456 RID: 17494
	[RequiredMember]
	public Spring25DialogueSpineData RightSpineData;

	// Token: 0x04004457 RID: 17495
	[RequiredMember]
	public List<Spring25DialogueChatData> ChatDataList;
}
