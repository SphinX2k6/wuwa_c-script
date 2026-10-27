using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000027 RID: 39
	public class StaticVariableRegister
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0000B432 File Offset: 0x00009632
		[NullableContext(1)]
		public static void RegisterAndExecute(Action initAction, Action resetAction)
		{
			StaticVariableRegister.RegisterAndExecute(initAction, resetAction);
		}
	}
}
