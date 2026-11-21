using System;
using System.Runtime.CompilerServices;

// Token: 0x020009CA RID: 2506
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25DialogueChatData
{
	// Token: 0x06006DE1 RID: 28129 RVA: 0x0021F1C7 File Offset: 0x0021D3C7
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25DialogueChatData()
	{
	}

	// Token: 0x04004451 RID: 17489
	[RequiredMember]
	public string ContentTextId;

	// Token: 0x04004452 RID: 17490
	[RequiredMember]
	public ESpring25DialogType Position;

	// Token: 0x04004453 RID: 17491
	[RequiredMember]
	public string SpineAnimName;
}
