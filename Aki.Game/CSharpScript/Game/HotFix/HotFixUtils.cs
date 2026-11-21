using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.HotFix
{
	// Token: 0x020061A0 RID: 24992
	public class HotFixUtils
	{
		// Token: 0x0603BF77 RID: 245623 RVA: 0x01108CAC File Offset: 0x01106EAC
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
