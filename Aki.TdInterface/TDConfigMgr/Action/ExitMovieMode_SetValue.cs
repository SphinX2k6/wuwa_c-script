using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001894 RID: 6292
	[NullableContext(2)]
	[Nullable(0)]
	public class ExitMovieMode_SetValue
	{
		// Token: 0x0400541F RID: 21535
		public float? BorderAnimDuration;

		// Token: 0x04005420 RID: 21536
		public IEnterMovieModeDurationType DurationType;

		// Token: 0x04005421 RID: 21537
		public IMovieModeFadeOutMaskConfig FadeOutMaskConfig;
	}
}
