using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B45 RID: 6981
	public class IInteractActions_SetValue
	{
		// Token: 0x04005B6E RID: 23406
		public EInteractOption Type;

		// Token: 0x04005B6F RID: 23407
		[Nullable(1)]
		public List<ActionInfo> Actions;
	}
}
