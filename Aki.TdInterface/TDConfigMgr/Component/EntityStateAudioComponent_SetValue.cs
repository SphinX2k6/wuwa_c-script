using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200010D RID: 269
	public class EntityStateAudioComponent_SetValue
	{
		// Token: 0x0400058F RID: 1423
		public bool? Disabled;

		// Token: 0x04000590 RID: 1424
		public IAkEventTypeConfig AkEventType;

		// Token: 0x04000591 RID: 1425
		public EAudioRangeType AudioRangeType;

		// Token: 0x04000592 RID: 1426
		public bool? EdIsLocked;

		// Token: 0x04000593 RID: 1427
		public List<IEntityStateAudioConfig> Config;
	}
}
