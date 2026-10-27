using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200171C RID: 5916
	[NullableContext(2)]
	[Nullable(0)]
	public class FadeInScreen_SetValue
	{
		// Token: 0x04004FFD RID: 20477
		public EFadeUiOverride? TypeOverride;

		// Token: 0x04004FFE RID: 20478
		public IEaseData Ease;

		// Token: 0x04004FFF RID: 20479
		public EFadeInScreenShowType? ScreenType;

		// Token: 0x04005000 RID: 20480
		public bool? KeepFadeAfterTreeEnd;

		// Token: 0x04005001 RID: 20481
		public bool? KeepFadeAfterTreeRollBack;

		// Token: 0x04005002 RID: 20482
		public IFadeBackgroundType FadeBackground;

		// Token: 0x04005003 RID: 20483
		public bool? OnlyLowMemoryDeviceExecute;
	}
}
