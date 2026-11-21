using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002004 RID: 8196
	public class ISceneUiSubtitleAppear_SetValue
	{
		// Token: 0x040067C9 RID: 26569
		public ISceneUiSubtitlePositionBase Position;

		// Token: 0x040067CA RID: 26570
		public bool? LockFacingCamera;

		// Token: 0x040067CB RID: 26571
		public bool? IsOccluded;

		// Token: 0x040067CC RID: 26572
		[Nullable(2)]
		public ISceneUiSubtitleLocalizationConfig LocalizationConfig;

		// Token: 0x040067CD RID: 26573
		public ESceneUiSubtitleStyleType Type;
	}
}
