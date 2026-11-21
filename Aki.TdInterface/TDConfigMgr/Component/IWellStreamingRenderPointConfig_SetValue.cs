using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000885 RID: 2181
	public class IWellStreamingRenderPointConfig_SetValue
	{
		// Token: 0x04001F23 RID: 7971
		public IPortalRenderConfig TargetConfig;

		// Token: 0x04001F24 RID: 7972
		public IRtSize RtSize;

		// Token: 0x04001F25 RID: 7973
		public bool? IsRenderStreamingPointEntity;

		// Token: 0x04001F26 RID: 7974
		[Nullable(2)]
		public string RtRenderRefPosActorKey;

		// Token: 0x04001F27 RID: 7975
		public string FallbackCubeMapTexturePath;
	}
}
