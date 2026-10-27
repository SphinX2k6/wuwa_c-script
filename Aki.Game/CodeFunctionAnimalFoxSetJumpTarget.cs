using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200316F RID: 12655
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxSetJumpTarget : CodeFunctionBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B399 RID: 111513 RVA: 0x0076D8CA File Offset: 0x0076BACA
	public CodeFunctionAnimalFoxSetJumpTarget(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B39A RID: 111514 RVA: 0x0076D8D4 File Offset: 0x0076BAD4
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		FVector fvector;
		if (!payload.VectorValues.TryGetValue("JumpTarget", out fvector))
		{
			return base.GetDefaultFailureResult("缺少JumpTarget参数");
		}
		this.SpecialSkill.SetJumpTarget(fvector);
		return base.GetDefaultSuccessResult();
	}

	// Token: 0x0400D468 RID: 54376
	public static readonly string FunctionName = "AnimalFox.SetJumpTarget";

	// Token: 0x0400D469 RID: 54377
	private const string JUMP_TARGET = "JumpTarget";
}
