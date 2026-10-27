using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000798 RID: 1944
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrafficAudioControl_SetValue
	{
		// Token: 0x04001C2C RID: 7212
		public EAudioControlType Type;

		// Token: 0x04001C2D RID: 7213
		public string EngineAudio;

		// Token: 0x04001C2E RID: 7214
		public string BrakingAudio;

		// Token: 0x04001C2F RID: 7215
		public string BrakingShortAudio;

		// Token: 0x04001C30 RID: 7216
		public string HornAudio;
	}
}
