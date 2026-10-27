using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000F6 RID: 246
	public class EntityAudioComponent_SetValue
	{
		// Token: 0x04000529 RID: 1321
		public bool? Disabled;

		// Token: 0x0400052A RID: 1322
		public bool? EdIsLocked;

		// Token: 0x0400052B RID: 1323
		[Nullable(1)]
		public IAkEventTypeConfig AkEventType;

		// Token: 0x0400052C RID: 1324
		public EAudioRangeType AudioRangeType;
	}
}
