using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02005193 RID: 20883
	public interface IRhythmShipChoseLevelViewData
	{
		// Token: 0x170065A6 RID: 26022
		// (get) Token: 0x06034226 RID: 213542
		// (set) Token: 0x06034227 RID: 213543
		ERhythmShipPlanetType OpenShowType { get; set; }

		// Token: 0x170065A7 RID: 26023
		// (get) Token: 0x06034228 RID: 213544
		// (set) Token: 0x06034229 RID: 213545
		int? PlanetId { get; set; }

		// Token: 0x170065A8 RID: 26024
		// (get) Token: 0x0603422A RID: 213546
		// (set) Token: 0x0603422B RID: 213547
		int? LevelId { get; set; }

		// Token: 0x170065A9 RID: 26025
		// (get) Token: 0x0603422C RID: 213548
		// (set) Token: 0x0603422D RID: 213549
		int? SubLevelId { get; set; }
	}
}
