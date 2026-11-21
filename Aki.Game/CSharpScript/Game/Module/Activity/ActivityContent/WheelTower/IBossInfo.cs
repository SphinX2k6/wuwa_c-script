using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F09 RID: 20233
	public interface IBossInfo
	{
		// Token: 0x170062D8 RID: 25304
		// (get) Token: 0x06032DC3 RID: 208323
		// (set) Token: 0x06032DC4 RID: 208324
		int WaveConfigId { get; set; }

		// Token: 0x170062D9 RID: 25305
		// (get) Token: 0x06032DC5 RID: 208325
		// (set) Token: 0x06032DC6 RID: 208326
		int Round { get; set; }

		// Token: 0x170062DA RID: 25306
		// (get) Token: 0x06032DC7 RID: 208327
		// (set) Token: 0x06032DC8 RID: 208328
		double HpPercentage { get; set; }

		// Token: 0x170062DB RID: 25307
		// (get) Token: 0x06032DC9 RID: 208329
		// (set) Token: 0x06032DCA RID: 208330
		double? LoseHpPercentage { get; set; }
	}
}
