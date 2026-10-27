using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F0E RID: 12046
[RequiredMember]
public class RequirementCritical : IRequirement
{
	// Token: 0x1700239E RID: 9118
	// (get) Token: 0x06019B4D RID: 105293 RVA: 0x006B1B06 File Offset: 0x006AFD06
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.ShouldCritical;
		}
	}

	// Token: 0x06019B4E RID: 105294 RVA: 0x006B1B09 File Offset: 0x006AFD09
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementCritical()
	{
	}

	// Token: 0x0400C173 RID: 49523
	[RequiredMember]
	public bool IsCritical;
}
