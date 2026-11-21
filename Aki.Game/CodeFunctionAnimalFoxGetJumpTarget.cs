using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026DA RID: 9946
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxGetJumpTarget : CodeFunctionBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E75 RID: 102005 RVA: 0x00792DEA File Offset: 0x00790FEA
	public CodeFunctionAnimalFoxGetJumpTarget(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E76 RID: 102006 RVA: 0x00792E00 File Offset: 0x00791000
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

	// Token: 0x0400D88E RID: 55438
	public static readonly string FunctionName = "AnimalFox.GetJumpTarget";

	// Token: 0x0400D88F RID: 55439
	private const string JUMP_TARGET = "JumpTarget";

	// Token: 0x0400D890 RID: 55440
	private readonly Vector CachedVector = Vector.Create();
}
