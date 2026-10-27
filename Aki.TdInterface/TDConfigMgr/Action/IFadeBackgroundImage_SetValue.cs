using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A50 RID: 6736
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundImage_SetValue
	{
		// Token: 0x04005911 RID: 22801
		public EFadeBackgroundType Type;

		// Token: 0x04005912 RID: 22802
		[Nullable(1)]
		public string BackgroundImage;

		// Token: 0x04005913 RID: 22803
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x04005914 RID: 22804
		public IFadeBackgroundFadeOutEffect FadeOutEffect;
	}
}
