using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003D RID: 61
	public class ChessmanComponent_SetValue
	{
		// Token: 0x04000159 RID: 345
		public bool? Disabled;

		// Token: 0x0400015A RID: 346
		public bool? EdIsLocked;

		// Token: 0x0400015B RID: 347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> StartMovingActions;

		// Token: 0x0400015C RID: 348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> EndMovingActions;
	}
}
