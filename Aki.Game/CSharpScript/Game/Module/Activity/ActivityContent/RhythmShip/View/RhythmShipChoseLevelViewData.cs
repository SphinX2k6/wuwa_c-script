using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006216 RID: 25110
	public class RhythmShipChoseLevelViewData : IRhythmShipChoseLevelViewData
	{
		// Token: 0x17009248 RID: 37448
		// (get) Token: 0x0603F56D RID: 259437 RVA: 0x00F4E616 File Offset: 0x00F4C816
		// (set) Token: 0x0603F56E RID: 259438 RVA: 0x00F4E61E File Offset: 0x00F4C81E
		public ERhythmShipPlanetType OpenShowType { get; set; }

		// Token: 0x17009249 RID: 37449
		// (get) Token: 0x0603F56F RID: 259439 RVA: 0x00F4E627 File Offset: 0x00F4C827
		// (set) Token: 0x0603F570 RID: 259440 RVA: 0x00F4E62F File Offset: 0x00F4C82F
		public int? PlanetId { get; set; }

		// Token: 0x1700924A RID: 37450
		// (get) Token: 0x0603F571 RID: 259441 RVA: 0x00F4E638 File Offset: 0x00F4C838
		// (set) Token: 0x0603F572 RID: 259442 RVA: 0x00F4E640 File Offset: 0x00F4C840
		public int? LevelId { get; set; }

		// Token: 0x1700924B RID: 37451
		// (get) Token: 0x0603F573 RID: 259443 RVA: 0x00F4E649 File Offset: 0x00F4C849
		// (set) Token: 0x0603F574 RID: 259444 RVA: 0x00F4E651 File Offset: 0x00F4C851
		public int? SubLevelId { get; set; }
	}
}
