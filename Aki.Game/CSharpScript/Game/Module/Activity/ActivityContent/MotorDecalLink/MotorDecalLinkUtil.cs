using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x020053B6 RID: 21430
	[NullableContext(1)]
	[Nullable(0)]
	public static class MotorDecalLinkUtil
	{
		// Token: 0x060354CB RID: 218315 RVA: 0x00EE3D7E File Offset: 0x00EE1F7E
		public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x060354CC RID: 218316 RVA: 0x00EE3D80 File Offset: 0x00EE1F80
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
