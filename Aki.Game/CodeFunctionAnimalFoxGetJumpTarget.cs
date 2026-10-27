using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200316D RID: 12653
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxGetJumpTarget : CodeFunctionBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B370 RID: 111472 RVA: 0x0076B486 File Offset: 0x00769686
	public CodeFunctionAnimalFoxGetJumpTarget(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B371 RID: 111473 RVA: 0x0076B49C File Offset: 0x0076969C
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		if (!this.SpecialSkill.TryGetJumpTarget(this.CachedVector))
		{
			return base.GetDefaultFailureResult("无合法JumpTarget");
		}
		FKuroCodeFunctionResult cachedResult = base.GetCachedResult();
		cachedResult.Values.VectorValues.Add("JumpTarget", this.CachedVector.ToUeVectorOld());
		return cachedResult;
	}

	// Token: 0x0400D42B RID: 54315
	public static readonly string FunctionName = "AnimalFox.GetJumpTarget";

	// Token: 0x0400D42C RID: 54316
	private const string JUMP_TARGET = "JumpTarget";

	// Token: 0x0400D42D RID: 54317
	private readonly Vector CachedVector = Vector.Create();
}
