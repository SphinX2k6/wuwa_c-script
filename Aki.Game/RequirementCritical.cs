using System;
using System.Runtime.CompilerServices;

// Token: 0x02002461 RID: 9313
[RequiredMember]
public class RequirementCritical : IRequirement
{
	// Token: 0x17002460 RID: 9312
	// (get) Token: 0x06017458 RID: 95320 RVA: 0x006D7E1E File Offset: 0x006D601E
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.ShouldCritical;
		}
	}

	// Token: 0x06017459 RID: 95321 RVA: 0x006D7E21 File Offset: 0x006D6021
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementCritical()
	{
	}

	// Token: 0x0400C515 RID: 50453
	[RequiredMember]
	public bool IsCritical;
}
