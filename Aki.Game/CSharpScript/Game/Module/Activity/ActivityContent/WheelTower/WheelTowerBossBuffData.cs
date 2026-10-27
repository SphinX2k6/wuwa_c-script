using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F2E RID: 24366
	public class WheelTowerBossBuffData : IWheelTowerBossBuffData
	{
		// Token: 0x17008F23 RID: 36643
		// (get) Token: 0x0603DE66 RID: 253542 RVA: 0x00EF5636 File Offset: 0x00EF3836
		// (set) Token: 0x0603DE67 RID: 253543 RVA: 0x00EF563E File Offset: 0x00EF383E
		public int Round { get; set; }

		// Token: 0x17008F24 RID: 36644
		// (get) Token: 0x0603DE68 RID: 253544 RVA: 0x00EF5647 File Offset: 0x00EF3847
		// (set) Token: 0x0603DE69 RID: 253545 RVA: 0x00EF564F File Offset: 0x00EF384F
		public int BuffId { get; set; }

		// Token: 0x17008F25 RID: 36645
		// (get) Token: 0x0603DE6A RID: 253546 RVA: 0x00EF5658 File Offset: 0x00EF3858
		// (set) Token: 0x0603DE6B RID: 253547 RVA: 0x00EF5660 File Offset: 0x00EF3860
		public bool IsActivate { get; set; }
	}
}
