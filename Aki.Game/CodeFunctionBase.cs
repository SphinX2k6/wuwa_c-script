using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003171 RID: 12657
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeFunctionBase : IStaticVariableResetter
{
	// Token: 0x0601B39F RID: 111519 RVA: 0x0076D975 File Offset: 0x0076BB75
	static CodeFunctionBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CodeFunctionBase.CreateStaticDefaultValue), new Action(CodeFunctionBase.ResetStaticDefaultValue));
	}

	// Token: 0x0601B3A0 RID: 111520 RVA: 0x0076D994 File Offset: 0x0076BB94
	public static void CreateStaticDefaultValue()
	{
		CodeFunctionBase._defaultSuccessResult = null;
		CodeFunctionBase._defaultFailureResult = null;
	}

	// Token: 0x0601B3A1 RID: 111521 RVA: 0x0076D9A2 File Offset: 0x0076BBA2
	public static void ResetStaticDefaultValue()
	{
		CodeFunctionBase._defaultSuccessResult = null;
		CodeFunctionBase._defaultFailureResult = null;
	}

	// Token: 0x0601B3A2 RID: 111522 RVA: 0x0076D9B0 File Offset: 0x0076BBB0
	public static FKuroCodeFunctionResult CreateCodeFunctionSuccessResult()
	{
		return new FKuroCodeFunctionResult
		{
			Success = true
		};
	}

	// Token: 0x0601B3A3 RID: 111523 RVA: 0x0076D9BE File Offset: 0x0076BBBE
	public static FKuroCodeFunctionResult CreateCodeFunctionFailureResult(string errorMessage)
	{
		return new FKuroCodeFunctionResult
		{
			Success = false,
			ErrorMessage = errorMessage
		};
	}

	// Token: 0x170025B9 RID: 9657
	// (get) Token: 0x0601B3A4 RID: 111524 RVA: 0x0076D9D3 File Offset: 0x0076BBD3
	protected static FKuroCodeFunctionResult DefaultSuccessResult
	{
		get
		{
			if (CodeFunctionBase._defaultSuccessResult == null)
			{
				CodeFunctionBase._defaultSuccessResult = CodeFunctionBase.CreateCodeFunctionSuccessResult();
			}
			return CodeFunctionBase._defaultSuccessResult;
		}
	}

	// Token: 0x170025BA RID: 9658
	// (get) Token: 0x0601B3A5 RID: 111525 RVA: 0x0076D9F1 File Offset: 0x0076BBF1
	protected static FKuroCodeFunctionResult DefaultFailureResult
	{
		get
		{
			if (CodeFunctionBase._defaultFailureResult == null)
			{
				CodeFunctionBase._defaultFailureResult = CodeFunctionBase.CreateCodeFunctionFailureResult("");
			}
			return CodeFunctionBase._defaultFailureResult;
		}
	}

	// Token: 0x0601B3A6 RID: 111526
	public abstract FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload);

	// Token: 0x0400D46B RID: 54379
	[Nullable(2)]
	private static FKuroCodeFunctionResult _defaultSuccessResult;

	// Token: 0x0400D46C RID: 54380
	[Nullable(2)]
	private static FKuroCodeFunctionResult _defaultFailureResult;
}
