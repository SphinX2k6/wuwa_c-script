using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000041 RID: 65
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientTriggerComponent_SetValue
	{
		// Token: 0x0400016C RID: 364
		public bool? Disabled;

		// Token: 0x0400016D RID: 365
		public bool? EdIsLocked;

		// Token: 0x0400016E RID: 366
		public ITriggerMatchConfig TriggerMatch;

		// Token: 0x0400016F RID: 367
		public ITriggeredConfig OnTriggerEnter;

		// Token: 0x04000170 RID: 368
		public ITriggeredConfig OnTriggerExit;
	}
}
