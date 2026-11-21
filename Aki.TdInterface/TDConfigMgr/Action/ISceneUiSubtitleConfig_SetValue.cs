using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002006 RID: 8198
	public class ISceneUiSubtitleConfig_SetValue
	{
		// Token: 0x040067D2 RID: 26578
		public ISceneUiSubtitlePositionBase Position;

		// Token: 0x040067D3 RID: 26579
		public bool? LockFacingCamera;

		// Token: 0x040067D4 RID: 26580
		public bool? IsOccluded;

		// Token: 0x040067D5 RID: 26581
		[Nullable(2)]
		public ISceneUiSubtitleLocalizationConfig LocalizationConfig;
	}
}
