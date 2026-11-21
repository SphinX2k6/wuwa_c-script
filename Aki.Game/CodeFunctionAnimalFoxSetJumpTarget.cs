using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026DC RID: 9948
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxSetJumpTarget : CodeFunctionBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E9E RID: 102046 RVA: 0x0079522E File Offset: 0x0079342E
	public CodeFunctionAnimalFoxSetJumpTarget(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E9F RID: 102047 RVA: 0x00795238 File Offset: 0x00793438
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

	// Token: 0x0400D8CB RID: 55499
	public static readonly string FunctionName = "AnimalFox.SetJumpTarget";

	// Token: 0x0400D8CC RID: 55500
	private const string JUMP_TARGET = "JumpTarget";
}
