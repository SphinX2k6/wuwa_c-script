using System;
using System.Runtime.CompilerServices;

// Token: 0x020010E4 RID: 4324
[RequiredMember]
public class ArtemisActivityCertificationViewParams
{
	// Token: 0x06007096 RID: 28822 RVA: 0x0016F9F1 File Offset: 0x0016DBF1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ArtemisActivityCertificationViewParams()
	{
	}

	// Token: 0x0400343C RID: 13372
	[RequiredMember]
	public bool IsPlayFixedDone;

	// Token: 0x0400343D RID: 13373
	[Nullable(1)]
	[RequiredMember]
	public Action Callback;
}
