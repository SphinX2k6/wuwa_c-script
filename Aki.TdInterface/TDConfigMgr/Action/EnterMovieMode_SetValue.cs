using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CA RID: 6090
	[NullableContext(2)]
	[Nullable(0)]
	public class EnterMovieMode_SetValue
	{
		// Token: 0x040050A5 RID: 20645
		public IMovieCameraConfig MovieCameraConfig;

		// Token: 0x040050A6 RID: 20646
		public IEnableFuncConfig EnableFuncConfig;

		// Token: 0x040050A7 RID: 20647
		public float? BorderAnimDuration;

		// Token: 0x040050A8 RID: 20648
		public IEnterMovieModeDurationType DurationType;

		// Token: 0x040050A9 RID: 20649
		public bool? AutoExitInFlow;
	}
}
