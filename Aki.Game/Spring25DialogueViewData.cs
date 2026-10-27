using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001513 RID: 5395
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25DialogueViewData
{
	// Token: 0x06009A04 RID: 39428 RVA: 0x00215433 File Offset: 0x00213633
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25DialogueViewData()
	{
	}

	// Token: 0x040043AE RID: 17326
	[RequiredMember]
	public bool IsOpening;

	// Token: 0x040043AF RID: 17327
	[RequiredMember]
	public Spring25DialogueSpineData LeftSpineData;

	// Token: 0x040043B0 RID: 17328
	[RequiredMember]
	public Spring25DialogueSpineData RightSpineData;

	// Token: 0x040043B1 RID: 17329
	[RequiredMember]
	public List<Spring25DialogueChatData> ChatDataList;
}
