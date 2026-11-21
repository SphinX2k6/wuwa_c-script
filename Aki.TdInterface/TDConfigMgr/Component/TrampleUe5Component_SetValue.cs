using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096E RID: 2414
	public class TrampleUe5Component_SetValue
	{
		// Token: 0x0400236B RID: 9067
		public bool? Disabled;

		// Token: 0x0400236C RID: 9068
		public bool? EdIsLocked;

		// Token: 0x0400236D RID: 9069
		public bool IsDisposable;

		// Token: 0x0400236E RID: 9070
		public List<ActionInfo> TriggerActions;

		// Token: 0x0400236F RID: 9071
		public List<ActionInfo> RecoveryActions;
	}
}
