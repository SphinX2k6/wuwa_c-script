using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000041 RID: 65
	public class ClientTriggerComponent_SetValue
	{
		// Token: 0x04000171 RID: 369
		public bool? Disabled;

		// Token: 0x04000172 RID: 370
		public bool? EdIsLocked;

		// Token: 0x04000173 RID: 371
		public ITriggerMatchConfig TriggerMatch;

		// Token: 0x04000174 RID: 372
		public ITriggeredConfig OnTriggerEnter;

		// Token: 0x04000175 RID: 373
		public ITriggeredConfig OnTriggerExit;
	}
}
