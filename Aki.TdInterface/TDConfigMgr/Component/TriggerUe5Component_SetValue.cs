using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D1 RID: 2257
	public class TriggerUe5Component_SetValue
	{
		// Token: 0x04002181 RID: 8577
		public bool? Disabled;

		// Token: 0x04002182 RID: 8578
		public bool? EdIsLocked;

		// Token: 0x04002183 RID: 8579
		public int MaxTriggerTimes;

		// Token: 0x04002184 RID: 8580
		public bool IsNotLoad;

		// Token: 0x04002185 RID: 8581
		[Nullable(1)]
		public ITriggerActions TriggerActions;
	}
}
