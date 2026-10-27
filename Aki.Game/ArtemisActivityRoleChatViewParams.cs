using System;
using System.Runtime.CompilerServices;

// Token: 0x020010EA RID: 4330
[RequiredMember]
public class ArtemisActivityRoleChatViewParams
{
	// Token: 0x060070CA RID: 28874 RVA: 0x00170026 File Offset: 0x0016E226
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ArtemisActivityRoleChatViewParams()
	{
	}

	// Token: 0x0400344B RID: 13387
	[Nullable(1)]
	[RequiredMember]
	public ArtemisActivityData Data;

	// Token: 0x0400344C RID: 13388
	[RequiredMember]
	public int DefaultIndex;
}
