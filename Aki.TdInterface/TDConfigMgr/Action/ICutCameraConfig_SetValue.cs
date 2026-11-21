using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE8 RID: 6888
	public class ICutCameraConfig_SetValue
	{
		// Token: 0x04005B2A RID: 23338
		public ICameraParams CameraParams;

		// Token: 0x04005B2B RID: 23339
		[Nullable(2)]
		public PlayFlow CutFlow;

		// Token: 0x04005B2C RID: 23340
		[Nullable(2)]
		public ICutCameraTimeParams CutTimeParams;
	}
}
