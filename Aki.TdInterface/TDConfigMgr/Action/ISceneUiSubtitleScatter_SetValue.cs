using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002014 RID: 8212
	public class ISceneUiSubtitleScatter_SetValue
	{
		// Token: 0x040067F4 RID: 26612
		public ISceneUiSubtitlePositionBase Position;

		// Token: 0x040067F5 RID: 26613
		public bool? LockFacingCamera;

		// Token: 0x040067F6 RID: 26614
		public bool? IsOccluded;

		// Token: 0x040067F7 RID: 26615
		[Nullable(2)]
		public ISceneUiSubtitleLocalizationConfig LocalizationConfig;

		// Token: 0x040067F8 RID: 26616
		public ESceneUiSubtitleStyleType Type;
	}
}
