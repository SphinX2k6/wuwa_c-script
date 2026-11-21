using System;
using System.Runtime.CompilerServices;

// Token: 0x0200059E RID: 1438
[RequiredMember]
public class ArtemisActivityRoleChatViewParams
{
	// Token: 0x06004460 RID: 17504 RVA: 0x001789E2 File Offset: 0x00176BE2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ArtemisActivityRoleChatViewParams()
	{
	}

	// Token: 0x040034E4 RID: 13540
	[Nullable(1)]
	[RequiredMember]
	public ArtemisActivityData Data;

	// Token: 0x040034E5 RID: 13541
	[RequiredMember]
	public int DefaultIndex;
}
