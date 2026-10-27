using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063D1 RID: 25553
	public interface IMowingRiskPercentageData
	{
		// Token: 0x170093F1 RID: 37873
		// (get) Token: 0x0604044A RID: 263242
		// (set) Token: 0x0604044B RID: 263243
		int Count { get; set; }

		// Token: 0x170093F2 RID: 37874
		// (get) Token: 0x0604044C RID: 263244
		// (set) Token: 0x0604044D RID: 263245
		int SuperLevel { get; set; }

		// Token: 0x170093F3 RID: 37875
		// (get) Token: 0x0604044E RID: 263246
		// (set) Token: 0x0604044F RID: 263247
		float Partial { get; set; }

		// Token: 0x170093F4 RID: 37876
		// (get) Token: 0x06040450 RID: 263248
		// (set) Token: 0x06040451 RID: 263249
		float Overall { get; set; }
	}
}
