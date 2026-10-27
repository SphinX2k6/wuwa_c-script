using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006301 RID: 25345
	public interface IPinballAttributeItemData
	{
		// Token: 0x170092BE RID: 37566
		// (get) Token: 0x0603FC6B RID: 261227
		// (set) Token: 0x0603FC6C RID: 261228
		bool IsBgShow { get; set; }

		// Token: 0x170092BF RID: 37567
		// (get) Token: 0x0603FC6D RID: 261229
		// (set) Token: 0x0603FC6E RID: 261230
		PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x170092C0 RID: 37568
		// (get) Token: 0x0603FC6F RID: 261231
		// (set) Token: 0x0603FC70 RID: 261232
		int AttributeValue { get; set; }
	}
}
