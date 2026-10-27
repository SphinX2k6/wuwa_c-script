using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002F0A RID: 12042
[RequiredMember]
public class RequirementAttributeInterval : IRequirement
{
	// Token: 0x1700239A RID: 9114
	// (get) Token: 0x06019B45 RID: 105285 RVA: 0x006B1AD9 File Offset: 0x006AFCD9
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedLifeInterval;
		}
	}

	// Token: 0x06019B46 RID: 105286 RVA: 0x006B1ADC File Offset: 0x006AFCDC
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementAttributeInterval()
	{
	}

	// Token: 0x0400C16E RID: 49518
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C16F RID: 49519
	[Nullable(1)]
	[RequiredMember]
	public AttributeIntervalCheck RequireInterval;
}
