using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE7 RID: 7143
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundSpine_SetValue
	{
		// Token: 0x04005D80 RID: 23936
		public EFadeBackgroundType Type;

		// Token: 0x04005D81 RID: 23937
		public int SpineId;

		// Token: 0x04005D82 RID: 23938
		public IFadeBackgroundFadeInEffect FadeInEffect;

		// Token: 0x04005D83 RID: 23939
		public IFadeBackgroundFadeOutEffect FadeOutEffect;
	}
}
