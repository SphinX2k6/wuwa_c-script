using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000104 RID: 260
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityStateAudioComponent_SetValue
	{
		// Token: 0x04000565 RID: 1381
		public bool? Disabled;

		// Token: 0x04000566 RID: 1382
		public IAkEventTypeConfig AkEventType;

		// Token: 0x04000567 RID: 1383
		public EAudioRangeType AudioRangeType;

		// Token: 0x04000568 RID: 1384
		public bool? EdIsLocked;

		// Token: 0x04000569 RID: 1385
		public List<IEntityStateAudioConfig> Config;
	}
}
