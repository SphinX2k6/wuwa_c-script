using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200534F RID: 21327
	public interface IMowingRiskPercentageData
	{
		// Token: 0x17006753 RID: 26451
		// (get) Token: 0x0603510B RID: 217355
		// (set) Token: 0x0603510C RID: 217356
		int Count { get; set; }

		// Token: 0x17006754 RID: 26452
		// (get) Token: 0x0603510D RID: 217357
		// (set) Token: 0x0603510E RID: 217358
		int SuperLevel { get; set; }

		// Token: 0x17006755 RID: 26453
		// (get) Token: 0x0603510F RID: 217359
		// (set) Token: 0x06035110 RID: 217360
		float Partial { get; set; }

		// Token: 0x17006756 RID: 26454
		// (get) Token: 0x06035111 RID: 217361
		// (set) Token: 0x06035112 RID: 217362
		float Overall { get; set; }
	}
}
