using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;

// Token: 0x02000091 RID: 145
[NullableContext(1)]
[Nullable(0)]
public static class EventArgsUtils
{
	// Token: 0x060004A5 RID: 1189 RVA: 0x0001A120 File Offset: 0x00018320
	public static void CastFail(Type except, Delegate handle, Enum name)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Event;
		ELogAuthor author = ELogAuthor.LFJW;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Handle转Action失败，委托类型不匹配\n期望: ");
		defaultInterpolatedStringHandler.AppendFormatted<Type>(except);
		defaultInterpolatedStringHandler.AppendLiteral("\n实际: ");
		defaultInterpolatedStringHandler.AppendFormatted(handle.GetDelegateInfo());
		string message = defaultInterpolatedStringHandler.ToStringAndClear();
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EventName", name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x0001A18C File Offset: 0x0001838C
	public static void CastFail(Type except, Delegate handle, long name)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Event;
		ELogAuthor author = ELogAuthor.LFJW;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Handle转Action失败，委托类型不匹配\n期望: ");
		defaultInterpolatedStringHandler.AppendFormatted<Type>(except);
		defaultInterpolatedStringHandler.AppendLiteral("\n实际: ");
		defaultInterpolatedStringHandler.AppendFormatted(handle.GetDelegateInfo());
		string message = defaultInterpolatedStringHandler.ToStringAndClear();
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EventName", name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}
}
