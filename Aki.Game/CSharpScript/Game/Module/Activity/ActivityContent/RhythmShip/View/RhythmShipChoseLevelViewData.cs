using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02005194 RID: 20884
	public class RhythmShipChoseLevelViewData : IRhythmShipChoseLevelViewData
	{
		// Token: 0x170065AA RID: 26026
		// (get) Token: 0x0603422E RID: 213550 RVA: 0x00E9556E File Offset: 0x00E9376E
		// (set) Token: 0x0603422F RID: 213551 RVA: 0x00E95576 File Offset: 0x00E93776
		public ERhythmShipPlanetType OpenShowType { get; set; }

		// Token: 0x170065AB RID: 26027
		// (get) Token: 0x06034230 RID: 213552 RVA: 0x00E9557F File Offset: 0x00E9377F
		// (set) Token: 0x06034231 RID: 213553 RVA: 0x00E95587 File Offset: 0x00E93787
		public int? PlanetId { get; set; }

		// Token: 0x170065AC RID: 26028
		// (get) Token: 0x06034232 RID: 213554 RVA: 0x00E95590 File Offset: 0x00E93790
		// (set) Token: 0x06034233 RID: 213555 RVA: 0x00E95598 File Offset: 0x00E93798
		public int? LevelId { get; set; }

		// Token: 0x170065AD RID: 26029
		// (get) Token: 0x06034234 RID: 213556 RVA: 0x00E955A1 File Offset: 0x00E937A1
		// (set) Token: 0x06034235 RID: 213557 RVA: 0x00E955A9 File Offset: 0x00E937A9
		public int? SubLevelId { get; set; }
	}
}
