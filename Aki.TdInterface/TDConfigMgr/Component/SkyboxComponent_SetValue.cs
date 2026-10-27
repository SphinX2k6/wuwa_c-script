using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089A RID: 2202
	[NullableContext(2)]
	[Nullable(0)]
	public class SkyboxComponent_SetValue
	{
		// Token: 0x0400204D RID: 8269
		public bool? Disabled;

		// Token: 0x0400204E RID: 8270
		public bool? EdIsLocked;

		// Token: 0x0400204F RID: 8271
		public string WeatherDataAsset;

		// Token: 0x04002050 RID: 8272
		public string PPTODDataAsset;

		// Token: 0x04002051 RID: 8273
		public int? SkyboxSetting;

		// Token: 0x04002052 RID: 8274
		public float? FadeTime;

		// Token: 0x04002053 RID: 8275
		public float? Priority;

		// Token: 0x04002054 RID: 8276
		public ISkyboxTrigger TriggerMode;
	}
}
