using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB7 RID: 8119
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithPlayFlow_SetValue
	{
		// Token: 0x04006BD9 RID: 27609
		public ETeleportTransitionType Type;

		// Token: 0x04006BDA RID: 27610
		[Nullable(1)]
		public PlayFlow Flow;

		// Token: 0x04006BDB RID: 27611
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x04006BDC RID: 27612
		public IFadeBackgroundFadeOutEffect FadeOutEffect;
	}
}
