using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F23 RID: 24355
	public class BossInfo : IBossInfo
	{
		// Token: 0x17008F0A RID: 36618
		// (get) Token: 0x0603DE30 RID: 253488 RVA: 0x00EF550D File Offset: 0x00EF370D
		// (set) Token: 0x0603DE31 RID: 253489 RVA: 0x00EF5515 File Offset: 0x00EF3715
		public int WaveConfigId { get; set; }

		// Token: 0x17008F0B RID: 36619
		// (get) Token: 0x0603DE32 RID: 253490 RVA: 0x00EF551E File Offset: 0x00EF371E
		// (set) Token: 0x0603DE33 RID: 253491 RVA: 0x00EF5526 File Offset: 0x00EF3726
		public int Round { get; set; }

		// Token: 0x17008F0C RID: 36620
		// (get) Token: 0x0603DE34 RID: 253492 RVA: 0x00EF552F File Offset: 0x00EF372F
		// (set) Token: 0x0603DE35 RID: 253493 RVA: 0x00EF5537 File Offset: 0x00EF3737
		public double HpPercentage { get; set; }

		// Token: 0x17008F0D RID: 36621
		// (get) Token: 0x0603DE36 RID: 253494 RVA: 0x00EF5540 File Offset: 0x00EF3740
		// (set) Token: 0x0603DE37 RID: 253495 RVA: 0x00EF5548 File Offset: 0x00EF3748
		public double? LoseHpPercentage { get; set; }
	}
}
