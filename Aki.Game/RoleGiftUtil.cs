using System;
using System.Runtime.CompilerServices;

// Token: 0x020014BA RID: 5306
[NullableContext(1)]
[Nullable(0)]
public static class RoleGiftUtil
{
	// Token: 0x0600966A RID: 38506 RVA: 0x00207AF7 File Offset: 0x00205CF7
	public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0600966B RID: 38507 RVA: 0x00207AF9 File Offset: 0x00205CF9
	public static void Error(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		Log.Instance.Error(ELogModule.Activity, ELogAuthor.TZJ, "[RoleGift] " + message, pairs);
	}
}
