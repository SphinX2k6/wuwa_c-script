using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F97 RID: 24471
	[NullableContext(1)]
	[Nullable(0)]
	public static class TotalTopUpUtil
	{
		// Token: 0x0603E12E RID: 254254 RVA: 0x00EFCBE4 File Offset: 0x00EFADE4
		public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0603E12F RID: 254255 RVA: 0x00EFCBE6 File Offset: 0x00EFADE6
		public static void Error(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			Log.Instance.Error(ELogModule.ActivityTotalTopUp, ELogAuthor.TZJ, message, pairs);
		}
	}
}
