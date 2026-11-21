using System;
using System.Runtime.CompilerServices;
using Sharphereal.Core;
using UnrealEngine.Utils;

// Token: 0x0200000C RID: 12
[StaticVariableRuleIgnore]
public static class StaticVariableRegister
{
	// Token: 0x06000075 RID: 117 RVA: 0x000068D0 File Offset: 0x00004AD0
	[NullableContext(1)]
	public static void RegisterAndExecute(Action initAction, Action resetAction)
	{
		try
		{
			StaticVariableRegistry.RegisterAndExecute(initAction, resetAction);
		}
		catch (Exception item) when (1)
		{
			string message = "LRX->执行静态变量创建函数异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Exception: ", item);
			UnrealLogger.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000692C File Offset: 0x00004B2C
	public static void CreateRequiredStaticDefaultValue()
	{
		string message = "LRX->执行静态变量创建";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Count: ", StaticVariableRegistry.Count);
		UnrealLogger.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		StaticVariableRegistry.CreateRequiredStaticDefaultValue();
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00006968 File Offset: 0x00004B68
	public static void ResetRequiredStaticDefaultValue()
	{
		string message = "LRX->执行静态变量重置";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Count: ", StaticVariableRegistry.Count);
		UnrealLogger.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		StaticVariableRegistry.ResetRequiredStaticDefaultValue();
	}
}
