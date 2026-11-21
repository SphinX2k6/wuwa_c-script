using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200527F RID: 21119
	public interface IPinballAttributeItemData
	{
		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x0603492C RID: 215340
		// (set) Token: 0x0603492D RID: 215341
		bool IsBgShow { get; set; }

		// Token: 0x17006621 RID: 26145
		// (get) Token: 0x0603492E RID: 215342
		// (set) Token: 0x0603492F RID: 215343
		PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x17006622 RID: 26146
		// (get) Token: 0x06034930 RID: 215344
		// (set) Token: 0x06034931 RID: 215345
		int AttributeValue { get; set; }
	}
}
