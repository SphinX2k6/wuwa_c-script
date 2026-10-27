using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAF RID: 8111
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomScreen_SetValue
	{
		// Token: 0x04006BB8 RID: 27576
		public ETeleportTransitionType Type;

		// Token: 0x04006BB9 RID: 27577
		[Nullable(1)]
		public ICustomScreenTypeBase ScreenType;

		// Token: 0x04006BBA RID: 27578
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x04006BBB RID: 27579
		public IFadeBackgroundFadeOutEffect FadeOutEffect;

		// Token: 0x04006BBC RID: 27580
		public float? KeepTime;

		// Token: 0x04006BBD RID: 27581
		public ICustomShowUi CustomShowUi;

		// Token: 0x04006BBE RID: 27582
		public string StartAkEvent;
	}
}
