using System;
using System.Runtime.CompilerServices;

// Token: 0x02001512 RID: 5394
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25DialogueChatData
{
	// Token: 0x06009A03 RID: 39427 RVA: 0x0021542B File Offset: 0x0021362B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25DialogueChatData()
	{
	}

	// Token: 0x040043AB RID: 17323
	[RequiredMember]
	public string ContentTextId;

	// Token: 0x040043AC RID: 17324
	[RequiredMember]
	public ESpring25DialogType Position;

	// Token: 0x040043AD RID: 17325
	[RequiredMember]
	public string SpineAnimName;
}
