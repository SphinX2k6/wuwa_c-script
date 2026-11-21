using System;
using System.Runtime.CompilerServices;

// Token: 0x0200096E RID: 2414
[NullableContext(1)]
[Nullable(0)]
public static class RoleGiftUtil
{
	// Token: 0x060069FF RID: 27135 RVA: 0x00210A63 File Offset: 0x0020EC63
	public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x06006A00 RID: 27136 RVA: 0x00210A65 File Offset: 0x0020EC65
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
