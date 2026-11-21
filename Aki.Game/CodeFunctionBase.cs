using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026DE RID: 9950
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeFunctionBase : IStaticVariableResetter
{
	// Token: 0x06018EA4 RID: 102052 RVA: 0x007952D9 File Offset: 0x007934D9
	static CodeFunctionBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CodeFunctionBase.CreateStaticDefaultValue), new Action(CodeFunctionBase.ResetStaticDefaultValue));
	}

	// Token: 0x06018EA5 RID: 102053 RVA: 0x007952F8 File Offset: 0x007934F8
	public static void CreateStaticDefaultValue()
	{
		CodeFunctionBase._defaultSuccessResult = null;
		CodeFunctionBase._defaultFailureResult = null;
	}

	// Token: 0x06018EA6 RID: 102054 RVA: 0x00795306 File Offset: 0x00793506
	public static void ResetStaticDefaultValue()
	{
		CodeFunctionBase._defaultSuccessResult = null;
		CodeFunctionBase._defaultFailureResult = null;
	}

	// Token: 0x06018EA7 RID: 102055 RVA: 0x00795314 File Offset: 0x00793514
	public static FKuroCodeFunctionResult CreateCodeFunctionSuccessResult()
	{
		return new FKuroCodeFunctionResult
		{
			Success = true
		};
	}

	// Token: 0x06018EA8 RID: 102056 RVA: 0x00795322 File Offset: 0x00793522
	public static FKuroCodeFunctionResult CreateCodeFunctionFailureResult(string errorMessage)
	{
		return new FKuroCodeFunctionResult
		{
			Success = false,
			ErrorMessage = errorMessage
		};
	}

	// Token: 0x170027AA RID: 10154
	// (get) Token: 0x06018EA9 RID: 102057 RVA: 0x00795337 File Offset: 0x00793537
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

	// Token: 0x170027AB RID: 10155
	// (get) Token: 0x06018EAA RID: 102058 RVA: 0x00795355 File Offset: 0x00793555
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

	// Token: 0x06018EAB RID: 102059
	public abstract FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload);

	// Token: 0x0400D8CE RID: 55502
	[Nullable(2)]
	private static FKuroCodeFunctionResult _defaultSuccessResult;

	// Token: 0x0400D8CF RID: 55503
	[Nullable(2)]
	private static FKuroCodeFunctionResult _defaultFailureResult;
}
