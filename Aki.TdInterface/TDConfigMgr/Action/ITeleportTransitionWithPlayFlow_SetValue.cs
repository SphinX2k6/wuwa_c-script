using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FA RID: 8698
	public class ITeleportTransitionWithPlayFlow_SetValue
	{
		// Token: 0x040071D4 RID: 29140
		public ETeleportTransitionType Type;

		// Token: 0x040071D5 RID: 29141
		public PlayFlow Flow;

		// Token: 0x040071D6 RID: 29142
		[Nullable(2)]
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x040071D7 RID: 29143
		[Nullable(2)]
		public IFadeBackgroundFadeOutEffect FadeOutEffect;
	}
}
