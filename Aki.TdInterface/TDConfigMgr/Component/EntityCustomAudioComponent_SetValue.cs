using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FC RID: 252
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCustomAudioComponent_SetValue
	{
		// Token: 0x04000542 RID: 1346
		public bool? Disabled;

		// Token: 0x04000543 RID: 1347
		public IAkEventTypeConfig AkEventType;

		// Token: 0x04000544 RID: 1348
		public EAudioRangeType AudioRangeType;

		// Token: 0x04000545 RID: 1349
		public bool? EdIsLocked;

		// Token: 0x04000546 RID: 1350
		public IAudioControlType AudioControlType;
	}
}
