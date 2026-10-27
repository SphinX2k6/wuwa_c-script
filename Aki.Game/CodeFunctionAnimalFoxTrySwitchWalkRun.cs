using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003170 RID: 12656
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxTrySwitchWalkRun : CodeFunctionBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B39C RID: 111516 RVA: 0x0076D924 File Offset: 0x0076BB24
	public CodeFunctionAnimalFoxTrySwitchWalkRun(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B39D RID: 111517 RVA: 0x0076D930 File Offset: 0x0076BB30
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

	// Token: 0x0400D46A RID: 54378
	public static readonly string FunctionName = "AnimalFox.TrySwitchWalkRun";
}
