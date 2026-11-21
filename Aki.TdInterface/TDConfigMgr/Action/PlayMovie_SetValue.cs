using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237D RID: 9085
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMovie_SetValue
	{
		// Token: 0x040075E1 RID: 30177
		[Nullable(0)]
		public string VideoName;

		// Token: 0x040075E2 RID: 30178
		public IMovieBackgroundFadeData BackgroundFade;

		// Token: 0x040075E3 RID: 30179
		public IMp4UiReplaceMaterial ProgramSpecialConfig;

		// Token: 0x040075E4 RID: 30180
		public float? Mp4FadeOutTime;

		// Token: 0x040075E5 RID: 30181
		public float? Mp4FadeInTime;

		// Token: 0x040075E6 RID: 30182
		public float? BlackBorderFadeOutTime;

		// Token: 0x040075E7 RID: 30183
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMp4FrameEvent> Mp4FrameEvents;

		// Token: 0x040075E8 RID: 30184
		public SetBlendAnim Mp4BlendAnim;
	}
}
