using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002462 RID: 9314
[RequiredMember]
public class RequirementElementType : IRequirement
{
	// Token: 0x17002461 RID: 9313
	// (get) Token: 0x0601745A RID: 95322 RVA: 0x006D7E29 File Offset: 0x006D6029
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedElementType;
		}
	}

	// Token: 0x0601745B RID: 95323 RVA: 0x006D7E2C File Offset: 0x006D602C
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementElementType()
	{
	}

	// Token: 0x0400C516 RID: 50454
	[Nullable(1)]
	[RequiredMember]
	public EElementType[] ElementTypes;
}
