using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000338 RID: 824
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityStateAudioConfig_SetValue
	{
		// Token: 0x04000DAA RID: 3498
		public string State;

		// Token: 0x04000DAB RID: 3499
		public string AkEvent;

		// Token: 0x04000DAC RID: 3500
		[Nullable(2)]
		public string LeaveAkEvent;

		// Token: 0x04000DAD RID: 3501
		[Nullable(2)]
		public IAudioFade AudioFade;

		// Token: 0x04000DAE RID: 3502
		public bool? IsBanVehicleRadio;
	}
}
