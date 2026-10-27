using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F22 RID: 24354
	public interface IBossInfo
	{
		// Token: 0x17008F06 RID: 36614
		// (get) Token: 0x0603DE28 RID: 253480
		// (set) Token: 0x0603DE29 RID: 253481
		int WaveConfigId { get; set; }

		// Token: 0x17008F07 RID: 36615
		// (get) Token: 0x0603DE2A RID: 253482
		// (set) Token: 0x0603DE2B RID: 253483
		int Round { get; set; }

		// Token: 0x17008F08 RID: 36616
		// (get) Token: 0x0603DE2C RID: 253484
		// (set) Token: 0x0603DE2D RID: 253485
		double HpPercentage { get; set; }

		// Token: 0x17008F09 RID: 36617
		// (get) Token: 0x0603DE2E RID: 253486
		// (set) Token: 0x0603DE2F RID: 253487
		double? LoseHpPercentage { get; set; }
	}
}
