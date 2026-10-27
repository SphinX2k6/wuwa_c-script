using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006215 RID: 25109
	public interface IRhythmShipChoseLevelViewData
	{
		// Token: 0x17009244 RID: 37444
		// (get) Token: 0x0603F565 RID: 259429
		// (set) Token: 0x0603F566 RID: 259430
		ERhythmShipPlanetType OpenShowType { get; set; }

		// Token: 0x17009245 RID: 37445
		// (get) Token: 0x0603F567 RID: 259431
		// (set) Token: 0x0603F568 RID: 259432
		int? PlanetId { get; set; }

		// Token: 0x17009246 RID: 37446
		// (get) Token: 0x0603F569 RID: 259433
		// (set) Token: 0x0603F56A RID: 259434
		int? LevelId { get; set; }

		// Token: 0x17009247 RID: 37447
		// (get) Token: 0x0603F56B RID: 259435
		// (set) Token: 0x0603F56C RID: 259436
		int? SubLevelId { get; set; }
	}
}
