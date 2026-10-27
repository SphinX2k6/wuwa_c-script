using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.HotFix
{
	// Token: 0x0200701F RID: 28703
	public class HotFixUtils
	{
		// Token: 0x06045DC1 RID: 286145 RVA: 0x0115E8B0 File Offset: 0x0115CAB0
		[NullableContext(1)]
		public static void EvalScript(string script)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "该功能暂时不支持";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("script", script);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}
}
