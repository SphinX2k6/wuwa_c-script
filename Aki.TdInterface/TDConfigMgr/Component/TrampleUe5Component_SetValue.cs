using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CB RID: 2251
	[NullableContext(1)]
	[Nullable(0)]
	public class TrampleUe5Component_SetValue
	{
		// Token: 0x0400215B RID: 8539
		public bool? Disabled;

		// Token: 0x0400215C RID: 8540
		public bool? EdIsLocked;

		// Token: 0x0400215D RID: 8541
		public bool IsDisposable;

		// Token: 0x0400215E RID: 8542
		public List<ActionInfo> TriggerActions;

		// Token: 0x0400215F RID: 8543
		public List<ActionInfo> RecoveryActions;
	}
}
