using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003172 RID: 12658
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeFunctionBase<[Nullable(0)] TSpecialSkill> : CodeFunctionBase where TSpecialSkill : SpecialSkillBase
{
	// Token: 0x0601B3A8 RID: 111528 RVA: 0x0076DA1C File Offset: 0x0076BC1C
	public CodeFunctionBase(TSpecialSkill specialSkill)
	{
		this.SpecialSkill = specialSkill;
	}

	// Token: 0x0601B3A9 RID: 111529 RVA: 0x0076DA2B File Offset: 0x0076BC2B
	protected FKuroCodeFunctionResult GetCachedResult()
	{
		if (this._cachedResult == null)
		{
			this._cachedResult = new FKuroCodeFunctionResult();
			this._cachedResult.Success = true;
		}
		return this._cachedResult;
	}

	// Token: 0x0601B3AA RID: 111530 RVA: 0x0076DA58 File Offset: 0x0076BC58
	protected FKuroCodeFunctionResult CreateSuccessResult()
	{
		return CodeFunctionBase.CreateCodeFunctionSuccessResult();
	}

	// Token: 0x0601B3AB RID: 111531 RVA: 0x0076DA5F File Offset: 0x0076BC5F
	protected FKuroCodeFunctionResult CreateFailureResult(string errorMessage)
	{
		return CodeFunctionBase.CreateCodeFunctionFailureResult(errorMessage);
	}

	// Token: 0x0601B3AC RID: 111532 RVA: 0x0076DA67 File Offset: 0x0076BC67
	protected FKuroCodeFunctionResult GetDefaultSuccessResult()
	{
		return CodeFunctionBase.DefaultSuccessResult;
	}

	// Token: 0x0601B3AD RID: 111533 RVA: 0x0076DA6E File Offset: 0x0076BC6E
	protected FKuroCodeFunctionResult GetDefaultFailureResult(string errorMessage)
	{
		CodeFunctionBase.DefaultFailureResult.ErrorMessage = errorMessage;
		return CodeFunctionBase.DefaultFailureResult;
	}

	// Token: 0x0400D46D RID: 54381
	protected readonly TSpecialSkill SpecialSkill;

	// Token: 0x0400D46E RID: 54382
	[Nullable(2)]
	private FKuroCodeFunctionResult _cachedResult;
}
