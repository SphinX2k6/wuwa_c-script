using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A52 RID: 6738
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundSpine_SetValue
	{
		// Token: 0x0400591B RID: 22811
		public EFadeBackgroundType Type;

		// Token: 0x0400591C RID: 22812
		public int SpineId;

		// Token: 0x0400591D RID: 22813
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x0400591E RID: 22814
		public IFadeBackgroundFadeOutEffect FadeOutEffect;
	}
}
