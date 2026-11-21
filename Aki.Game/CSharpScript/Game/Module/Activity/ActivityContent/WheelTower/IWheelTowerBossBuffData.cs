using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F14 RID: 20244
	public interface IWheelTowerBossBuffData
	{
		// Token: 0x170062F2 RID: 25330
		// (get) Token: 0x06032DFB RID: 208379
		// (set) Token: 0x06032DFC RID: 208380
		int Round { get; set; }

		// Token: 0x170062F3 RID: 25331
		// (get) Token: 0x06032DFD RID: 208381
		// (set) Token: 0x06032DFE RID: 208382
		int BuffId { get; set; }

		// Token: 0x170062F4 RID: 25332
		// (get) Token: 0x06032DFF RID: 208383
		// (set) Token: 0x06032E00 RID: 208384
		bool IsActivate { get; set; }
	}
}
