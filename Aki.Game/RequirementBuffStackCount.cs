using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F17 RID: 12055
[RequiredMember]
public class RequirementBuffStackCount : IRequirement
{
	// Token: 0x170023A7 RID: 9127
	// (get) Token: 0x06019B5F RID: 105311 RVA: 0x006B1B6F File Offset: 0x006AFD6F
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.BuffStackCount;
		}
	}

	// Token: 0x06019B60 RID: 105312 RVA: 0x006B1B73 File Offset: 0x006AFD73
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBuffStackCount()
	{
	}

	// Token: 0x0400C180 RID: 49536
	[RequiredMember]
	public long BuffId;

	// Token: 0x0400C181 RID: 49537
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C182 RID: 49538
	[RequiredMember]
	public int MinStack;

	// Token: 0x0400C183 RID: 49539
	[RequiredMember]
	public int MaxStack;
}
