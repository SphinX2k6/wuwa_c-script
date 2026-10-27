using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x020062FD RID: 25341
	public interface IPinballAttributeDetailItemData
	{
		// Token: 0x170092B6 RID: 37558
		// (get) Token: 0x0603FC50 RID: 261200
		// (set) Token: 0x0603FC51 RID: 261201
		bool IsBgShow { get; set; }

		// Token: 0x170092B7 RID: 37559
		// (get) Token: 0x0603FC52 RID: 261202
		// (set) Token: 0x0603FC53 RID: 261203
		PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x170092B8 RID: 37560
		// (get) Token: 0x0603FC54 RID: 261204
		// (set) Token: 0x0603FC55 RID: 261205
		int AttributeValue { get; set; }

		// Token: 0x170092B9 RID: 37561
		// (get) Token: 0x0603FC56 RID: 261206
		// (set) Token: 0x0603FC57 RID: 261207
		bool IsExpanded { get; set; }
	}
}
