using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026DF RID: 9951
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeFunctionBase<[Nullable(0)] TSpecialSkill> : CodeFunctionBase where TSpecialSkill : SpecialSkillBase
{
	// Token: 0x06018EAD RID: 102061 RVA: 0x00795380 File Offset: 0x00793580
	public CodeFunctionBase(TSpecialSkill specialSkill)
	{
		this.SpecialSkill = specialSkill;
	}

	// Token: 0x06018EAE RID: 102062 RVA: 0x0079538F File Offset: 0x0079358F
	protected FKuroCodeFunctionResult GetCachedResult()
	{
		if (this._cachedResult == null)
		{
			this._cachedResult = new FKuroCodeFunctionResult();
			this._cachedResult.Success = true;
		}
		return this._cachedResult;
	}

	// Token: 0x06018EAF RID: 102063 RVA: 0x007953BC File Offset: 0x007935BC
	protected FKuroCodeFunctionResult CreateSuccessResult()
	{
		return CodeFunctionBase.CreateCodeFunctionSuccessResult();
	}

	// Token: 0x06018EB0 RID: 102064 RVA: 0x007953C3 File Offset: 0x007935C3
	protected FKuroCodeFunctionResult CreateFailureResult(string errorMessage)
	{
		return CodeFunctionBase.CreateCodeFunctionFailureResult(errorMessage);
	}

	// Token: 0x06018EB1 RID: 102065 RVA: 0x007953CB File Offset: 0x007935CB
	protected FKuroCodeFunctionResult GetDefaultSuccessResult()
	{
		return CodeFunctionBase.DefaultSuccessResult;
	}

	// Token: 0x06018EB2 RID: 102066 RVA: 0x007953D2 File Offset: 0x007935D2
	protected FKuroCodeFunctionResult GetDefaultFailureResult(string errorMessage)
	{
		CodeFunctionBase.DefaultFailureResult.ErrorMessage = errorMessage;
		return CodeFunctionBase.DefaultFailureResult;
	}

	// Token: 0x0400D8D0 RID: 55504
	protected readonly TSpecialSkill SpecialSkill;

	// Token: 0x0400D8D1 RID: 55505
	[Nullable(2)]
	private FKuroCodeFunctionResult _cachedResult;
}
