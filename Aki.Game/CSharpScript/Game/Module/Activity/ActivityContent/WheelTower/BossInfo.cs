using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F0A RID: 20234
	public class BossInfo : IBossInfo
	{
		// Token: 0x170062DC RID: 25308
		// (get) Token: 0x06032DCB RID: 208331 RVA: 0x00E47239 File Offset: 0x00E45439
		// (set) Token: 0x06032DCC RID: 208332 RVA: 0x00E47241 File Offset: 0x00E45441
		public int WaveConfigId { get; set; }

		// Token: 0x170062DD RID: 25309
		// (get) Token: 0x06032DCD RID: 208333 RVA: 0x00E4724A File Offset: 0x00E4544A
		// (set) Token: 0x06032DCE RID: 208334 RVA: 0x00E47252 File Offset: 0x00E45452
		public int Round { get; set; }

		// Token: 0x170062DE RID: 25310
		// (get) Token: 0x06032DCF RID: 208335 RVA: 0x00E4725B File Offset: 0x00E4545B
		// (set) Token: 0x06032DD0 RID: 208336 RVA: 0x00E47263 File Offset: 0x00E45463
		public double HpPercentage { get; set; }

		// Token: 0x170062DF RID: 25311
		// (get) Token: 0x06032DD1 RID: 208337 RVA: 0x00E4726C File Offset: 0x00E4546C
		// (set) Token: 0x06032DD2 RID: 208338 RVA: 0x00E47274 File Offset: 0x00E45474
		public double? LoseHpPercentage { get; set; }
	}
}
