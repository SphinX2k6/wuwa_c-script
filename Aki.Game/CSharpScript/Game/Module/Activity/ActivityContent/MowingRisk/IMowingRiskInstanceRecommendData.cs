using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005341 RID: 21313
	[NullableContext(1)]
	public interface IMowingRiskInstanceRecommendData
	{
		// Token: 0x1700672F RID: 26415
		// (get) Token: 0x060350BC RID: 217276
		// (set) Token: 0x060350BD RID: 217277
		string TextId { get; set; }

		// Token: 0x17006730 RID: 26416
		// (get) Token: 0x060350BE RID: 217278
		// (set) Token: 0x060350BF RID: 217279
		string[] TextArgs { get; set; }

		// Token: 0x17006731 RID: 26417
		// (get) Token: 0x060350C0 RID: 217280
		// (set) Token: 0x060350C1 RID: 217281
		int RecommendLevel { get; set; }
	}
}
