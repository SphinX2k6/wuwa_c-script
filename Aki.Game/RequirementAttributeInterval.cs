using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x0200245D RID: 9309
[RequiredMember]
public class RequirementAttributeInterval : IRequirement
{
	// Token: 0x1700245C RID: 9308
	// (get) Token: 0x06017450 RID: 95312 RVA: 0x006D7DF1 File Offset: 0x006D5FF1
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedLifeInterval;
		}
	}

	// Token: 0x06017451 RID: 95313 RVA: 0x006D7DF4 File Offset: 0x006D5FF4
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementAttributeInterval()
	{
	}

	// Token: 0x0400C510 RID: 50448
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C511 RID: 50449
	[Nullable(1)]
	[RequiredMember]
	public AttributeIntervalCheck RequireInterval;
}
