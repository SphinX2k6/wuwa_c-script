using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F15 RID: 20245
	public class WheelTowerBossBuffData : IWheelTowerBossBuffData
	{
		// Token: 0x170062F5 RID: 25333
		// (get) Token: 0x06032E01 RID: 208385 RVA: 0x00E47362 File Offset: 0x00E45562
		// (set) Token: 0x06032E02 RID: 208386 RVA: 0x00E4736A File Offset: 0x00E4556A
		public int Round { get; set; }

		// Token: 0x170062F6 RID: 25334
		// (get) Token: 0x06032E03 RID: 208387 RVA: 0x00E47373 File Offset: 0x00E45573
		// (set) Token: 0x06032E04 RID: 208388 RVA: 0x00E4737B File Offset: 0x00E4557B
		public int BuffId { get; set; }

		// Token: 0x170062F7 RID: 25335
		// (get) Token: 0x06032E05 RID: 208389 RVA: 0x00E47384 File Offset: 0x00E45584
		// (set) Token: 0x06032E06 RID: 208390 RVA: 0x00E4738C File Offset: 0x00E4558C
		public bool IsActivate { get; set; }
	}
}
