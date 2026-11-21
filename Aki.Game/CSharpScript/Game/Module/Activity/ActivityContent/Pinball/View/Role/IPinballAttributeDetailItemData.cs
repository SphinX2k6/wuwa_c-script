using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200527B RID: 21115
	public interface IPinballAttributeDetailItemData
	{
		// Token: 0x17006618 RID: 26136
		// (get) Token: 0x06034911 RID: 215313
		// (set) Token: 0x06034912 RID: 215314
		bool IsBgShow { get; set; }

		// Token: 0x17006619 RID: 26137
		// (get) Token: 0x06034913 RID: 215315
		// (set) Token: 0x06034914 RID: 215316
		PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x1700661A RID: 26138
		// (get) Token: 0x06034915 RID: 215317
		// (set) Token: 0x06034916 RID: 215318
		int AttributeValue { get; set; }

		// Token: 0x1700661B RID: 26139
		// (get) Token: 0x06034917 RID: 215319
		// (set) Token: 0x06034918 RID: 215320
		bool IsExpanded { get; set; }
	}
}
