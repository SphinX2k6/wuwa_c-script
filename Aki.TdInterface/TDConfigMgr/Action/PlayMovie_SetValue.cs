using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211C RID: 8476
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMovie_SetValue
	{
		// Token: 0x04006FAD RID: 28589
		[Nullable(1)]
		public string VideoName;

		// Token: 0x04006FAE RID: 28590
		public IMovieBackgroundFadeData BackgroundFade;

		// Token: 0x04006FAF RID: 28591
		public IMp4UiReplaceMaterial ProgramSpecialConfig;

		// Token: 0x04006FB0 RID: 28592
		public float? Mp4FadeOutTime;

		// Token: 0x04006FB1 RID: 28593
		public float? BlackBorderFadeOutTime;

		// Token: 0x04006FB2 RID: 28594
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMp4FrameEvent> Mp4FrameEvents;

		// Token: 0x04006FB3 RID: 28595
		public SetBlendAnim Mp4BlendAnim;
	}
}
