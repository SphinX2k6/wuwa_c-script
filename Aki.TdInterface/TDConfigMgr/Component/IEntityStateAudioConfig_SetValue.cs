using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037F RID: 895
	public class IEntityStateAudioConfig_SetValue
	{
		// Token: 0x04000E95 RID: 3733
		public string State;

		// Token: 0x04000E96 RID: 3734
		public string AkEvent;

		// Token: 0x04000E97 RID: 3735
		[Nullable(2)]
		public string LeaveAkEvent;

		// Token: 0x04000E98 RID: 3736
		[Nullable(2)]
		public IAudioFade AudioFade;

		// Token: 0x04000E99 RID: 3737
		public bool? IsBanVehicleRadio;
	}
}
