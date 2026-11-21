using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F2F RID: 20271
	public class WheelTowerScoreLevelTargetData
	{
		// Token: 0x06032F3B RID: 208699 RVA: 0x00E479FA File Offset: 0x00E45BFA
		public WheelTowerScoreLevelTargetData(int levelId, int score)
		{
			this.LevelId = levelId;
			this.Score = score;
		}

		// Token: 0x1700638B RID: 25483
		// (get) Token: 0x06032F3C RID: 208700 RVA: 0x00E47A10 File Offset: 0x00E45C10
		// (set) Token: 0x06032F3D RID: 208701 RVA: 0x00E47A18 File Offset: 0x00E45C18
		public int LevelId { get; set; }

		// Token: 0x1700638C RID: 25484
		// (get) Token: 0x06032F3E RID: 208702 RVA: 0x00E47A21 File Offset: 0x00E45C21
		// (set) Token: 0x06032F3F RID: 208703 RVA: 0x00E47A29 File Offset: 0x00E45C29
		public int Score { get; set; }
	}
}
