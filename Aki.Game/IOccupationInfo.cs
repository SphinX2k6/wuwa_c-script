using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D84 RID: 7556
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class IOccupationInfo
{
	// Token: 0x0600E54D RID: 58701 RVA: 0x0036023F File Offset: 0x0035E43F
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public IOccupationInfo()
	{
	}

	// Token: 0x04006A12 RID: 27154
	[RequiredMember]
	public string ResourceName;

	// Token: 0x04006A13 RID: 27155
	[RequiredMember]
	public string QuestName;

	// Token: 0x04006A14 RID: 27156
	[RequiredMember]
	public long TreeIncId;
}
