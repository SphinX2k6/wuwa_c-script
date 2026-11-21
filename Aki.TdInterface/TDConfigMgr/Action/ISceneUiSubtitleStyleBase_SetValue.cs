using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002016 RID: 8214
	public class ISceneUiSubtitleStyleBase_SetValue
	{
		// Token: 0x040067FD RID: 26621
		public ISceneUiSubtitlePositionBase Position;

		// Token: 0x040067FE RID: 26622
		public bool? LockFacingCamera;

		// Token: 0x040067FF RID: 26623
		public bool? IsOccluded;

		// Token: 0x04006800 RID: 26624
		[Nullable(2)]
		public ISceneUiSubtitleLocalizationConfig LocalizationConfig;

		// Token: 0x04006801 RID: 26625
		public ESceneUiSubtitleStyleType Type;
	}
}
