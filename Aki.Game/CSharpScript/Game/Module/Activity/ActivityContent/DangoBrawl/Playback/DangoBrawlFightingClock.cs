using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x02006866 RID: 26726
	public class DangoBrawlFightingClock
	{
		// Token: 0x06042BE1 RID: 273377 RVA: 0x0103DDB4 File Offset: 0x0103BFB4
		public float Tick(float deltaMs)
		{
			this.ElapsedMs += deltaMs;
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			DangoBrawlBattleReportPlayer dangoBrawlBattleReportPlayer = (battleManager != null) ? battleManager.BattleReportPlayer : null;
			if (dangoBrawlBattleReportPlayer == null || !dangoBrawlBattleReportPlayer.IsFightOver())
			{
				this.FightingElapsedMs = this.ElapsedMs;
			}
			return this.ElapsedMs;
		}

		// Token: 0x1700978D RID: 38797
		// (get) Token: 0x06042BE2 RID: 273378 RVA: 0x0103DE04 File Offset: 0x0103C004
		public float Elapsed
		{
			get
			{
				return this.ElapsedMs;
			}
		}

		// Token: 0x1700978E RID: 38798
		// (get) Token: 0x06042BE3 RID: 273379 RVA: 0x0103DE0C File Offset: 0x0103C00C
		public float FightingElapsed
		{
			get
			{
				return this.FightingElapsedMs;
			}
		}

		// Token: 0x04022BD7 RID: 142295
		private float ElapsedMs;

		// Token: 0x04022BD8 RID: 142296
		private float FightingElapsedMs;
	}
}
