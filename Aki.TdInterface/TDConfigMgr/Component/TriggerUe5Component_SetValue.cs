using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000974 RID: 2420
	public class TriggerUe5Component_SetValue
	{
		// Token: 0x04002391 RID: 9105
		public bool? Disabled;

		// Token: 0x04002392 RID: 9106
		public bool? EdIsLocked;

		// Token: 0x04002393 RID: 9107
		public int MaxTriggerTimes;

		// Token: 0x04002394 RID: 9108
		public bool IsNotLoad;

		// Token: 0x04002395 RID: 9109
		public ITriggerActions TriggerActions;
	}
}
