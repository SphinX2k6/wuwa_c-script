using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F7E RID: 20350
	[NullableContext(1)]
	[Nullable(0)]
	public static class TotalTopUpUtil
	{
		// Token: 0x060330C8 RID: 209096 RVA: 0x00E4E89C File Offset: 0x00E4CA9C
		public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x060330C9 RID: 209097 RVA: 0x00E4E89E File Offset: 0x00E4CA9E
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
