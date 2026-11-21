using System;
using System.Runtime.CompilerServices;

// Token: 0x02000598 RID: 1432
[RequiredMember]
public class ArtemisActivityCertificationViewParams
{
	// Token: 0x0600442C RID: 17452 RVA: 0x001783AD File Offset: 0x001765AD
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ArtemisActivityCertificationViewParams()
	{
	}

	// Token: 0x040034D5 RID: 13525
	[RequiredMember]
	public bool IsPlayFixedDone;

	// Token: 0x040034D6 RID: 13526
	[Nullable(1)]
	[RequiredMember]
	public Action Callback;
}
