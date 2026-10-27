using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195D RID: 6493
	[NullableContext(2)]
	[Nullable(0)]
	public class ICutCameraConfig_SetValue
	{
		// Token: 0x040056D6 RID: 22230
		[Nullable(1)]
		public ICameraParams CameraParams;

		// Token: 0x040056D7 RID: 22231
		public PlayFlow CutFlow;

		// Token: 0x040056D8 RID: 22232
		public ICutCameraTimeParams CutTimeParams;
	}
}
