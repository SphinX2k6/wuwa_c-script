using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026DD RID: 9949
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxTrySwitchWalkRun : CodeFunctionBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018EA1 RID: 102049 RVA: 0x00795288 File Offset: 0x00793488
	public CodeFunctionAnimalFoxTrySwitchWalkRun(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EA2 RID: 102050 RVA: 0x00795294 File Offset: 0x00793494
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		CharacterUnifiedStateComponent component = this.SpecialSkill.GetOwnerEntity().GetComponent<CharacterUnifiedStateComponent>();
		if (component == null)
		{
			return base.GetDefaultFailureResult("CharacterUnifiedStateComponent not found");
		}
		component.WalkPress();
		return base.GetDefaultSuccessResult();
	}

	// Token: 0x0400D8CD RID: 55501
	public static readonly string FunctionName = "AnimalFox.TrySwitchWalkRun";
}
