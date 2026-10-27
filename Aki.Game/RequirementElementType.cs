using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002F0F RID: 12047
[RequiredMember]
public class RequirementElementType : IRequirement
{
	// Token: 0x1700239F RID: 9119
	// (get) Token: 0x06019B4F RID: 105295 RVA: 0x006B1B11 File Offset: 0x006AFD11
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedElementType;
		}
	}

	// Token: 0x06019B50 RID: 105296 RVA: 0x006B1B14 File Offset: 0x006AFD14
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementElementType()
	{
	}

	// Token: 0x0400C174 RID: 49524
	[Nullable(1)]
	[RequiredMember]
	public EElementType[] ElementTypes;
}
