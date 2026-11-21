using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093D RID: 2365
	[NullableContext(2)]
	[Nullable(0)]
	public class SkyboxComponent_SetValue
	{
		// Token: 0x0400225F RID: 8799
		public bool? Disabled;

		// Token: 0x04002260 RID: 8800
		public bool? EdIsLocked;

		// Token: 0x04002261 RID: 8801
		public string WeatherDataAsset;

		// Token: 0x04002262 RID: 8802
		public string PPTODDataAsset;

		// Token: 0x04002263 RID: 8803
		public int? SkyboxSetting;

		// Token: 0x04002264 RID: 8804
		public float? FadeTime;

		// Token: 0x04002265 RID: 8805
		public float? Priority;

		// Token: 0x04002266 RID: 8806
		public ISkyboxTrigger TriggerMode;
	}
}
