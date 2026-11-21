using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001899 RID: 6297
	[NullableContext(2)]
	[Nullable(0)]
	public class FadeInScreen_SetValue
	{
		// Token: 0x0400542C RID: 21548
		public EFadeUiOverride? TypeOverride;

		// Token: 0x0400542D RID: 21549
		public IEaseData Ease;

		// Token: 0x0400542E RID: 21550
		public EFadeInScreenShowType? ScreenType;

		// Token: 0x0400542F RID: 21551
		public bool? KeepFadeAfterTreeEnd;

		// Token: 0x04005430 RID: 21552
		public bool? KeepFadeAfterTreeRollBack;

		// Token: 0x04005431 RID: 21553
		public IFadeBackgroundType FadeBackground;

		// Token: 0x04005432 RID: 21554
		public bool? OnlyLowMemoryDeviceExecute;
	}
}
