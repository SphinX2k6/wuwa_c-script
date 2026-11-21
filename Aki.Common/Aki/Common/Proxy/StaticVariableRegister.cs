using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000028 RID: 40
	public class StaticVariableRegister
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0000EBFE File Offset: 0x0000CDFE
		[NullableContext(1)]
		public static void RegisterAndExecute(Action initAction, Action resetAction)
		{
			StaticVariableRegister.RegisterAndExecute(initAction, resetAction);
		}
	}
}
