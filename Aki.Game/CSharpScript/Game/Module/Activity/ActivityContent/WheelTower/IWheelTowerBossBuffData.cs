using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F2D RID: 24365
	public interface IWheelTowerBossBuffData
	{
		// Token: 0x17008F20 RID: 36640
		// (get) Token: 0x0603DE60 RID: 253536
		// (set) Token: 0x0603DE61 RID: 253537
		int Round { get; set; }

		// Token: 0x17008F21 RID: 36641
		// (get) Token: 0x0603DE62 RID: 253538
		// (set) Token: 0x0603DE63 RID: 253539
		int BuffId { get; set; }

		// Token: 0x17008F22 RID: 36642
		// (get) Token: 0x0603DE64 RID: 253540
		// (set) Token: 0x0603DE65 RID: 253541
		bool IsActivate { get; set; }
	}
}
