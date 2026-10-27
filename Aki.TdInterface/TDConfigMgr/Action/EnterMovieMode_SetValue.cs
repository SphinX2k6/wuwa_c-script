using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165A RID: 5722
	[NullableContext(2)]
	[Nullable(0)]
	public class EnterMovieMode_SetValue
	{
		// Token: 0x04004CAA RID: 19626
		public IMovieCameraConfig MovieCameraConfig;

		// Token: 0x04004CAB RID: 19627
		public IEnableFuncConfig EnableFuncConfig;

		// Token: 0x04004CAC RID: 19628
		public float? BorderAnimDuration;

		// Token: 0x04004CAD RID: 19629
		public IEnterMovieModeDurationType DurationType;

		// Token: 0x04004CAE RID: 19630
		public bool? AutoExitInFlow;
	}
}
