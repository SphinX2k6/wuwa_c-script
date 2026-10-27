using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E2 RID: 2018
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderPointConfig_SetValue
	{
		// Token: 0x04001D17 RID: 7447
		public IPortalRenderConfig TargetConfig;

		// Token: 0x04001D18 RID: 7448
		public IRtSize RtSize;

		// Token: 0x04001D19 RID: 7449
		public bool? IsRenderStreamingPointEntity;

		// Token: 0x04001D1A RID: 7450
		[Nullable(2)]
		public string RtRenderRefPosActorKey;

		// Token: 0x04001D1B RID: 7451
		public string FallbackCubeMapTexturePath;
	}
}
