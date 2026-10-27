using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006438 RID: 25656
	[NullableContext(1)]
	[Nullable(0)]
	public static class MotorDecalLinkUtil
	{
		// Token: 0x0604080A RID: 264202 RVA: 0x00F9CE02 File Offset: 0x00F9B002
		public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0604080B RID: 264203 RVA: 0x00F9CE04 File Offset: 0x00F9B004
		public static void Error(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.TZJ, "[摩托贴纸联动33] " + message, pairs);
		}
	}
}
