using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE5 RID: 7141
	public class IFadeBackgroundImage_SetValue
	{
		// Token: 0x04005D76 RID: 23926
		public EFadeBackgroundType Type;

		// Token: 0x04005D77 RID: 23927
		public string BackgroundImage;

		// Token: 0x04005D78 RID: 23928
		[Nullable(2)]
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x04005D79 RID: 23929
		[Nullable(2)]
		public IFadeBackgroundFadeOutEffect FadeOutEffect;
	}
}
