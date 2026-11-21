using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003D RID: 61
	public class ChessmanComponent_SetValue
	{
		// Token: 0x0400015E RID: 350
		public bool? Disabled;

		// Token: 0x0400015F RID: 351
		public bool? EdIsLocked;

		// Token: 0x04000160 RID: 352
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> StartMovingActions;

		// Token: 0x04000161 RID: 353
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> EndMovingActions;
	}
}
