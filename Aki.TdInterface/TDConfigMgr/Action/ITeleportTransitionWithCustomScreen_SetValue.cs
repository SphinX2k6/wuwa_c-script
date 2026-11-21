using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F2 RID: 8690
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomScreen_SetValue
	{
		// Token: 0x040071B3 RID: 29107
		public ETeleportTransitionType Type;

		// Token: 0x040071B4 RID: 29108
		[Nullable(0)]
		public ICustomScreenTypeBase ScreenType;

		// Token: 0x040071B5 RID: 29109
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x040071B6 RID: 29110
		public IFadeBackgroundFadeOutEffect FadeOutEffect;

		// Token: 0x040071B7 RID: 29111
		public float? KeepTime;

		// Token: 0x040071B8 RID: 29112
		public ICustomShowUi CustomShowUi;

		// Token: 0x040071B9 RID: 29113
		public string StartAkEvent;
	}
}
