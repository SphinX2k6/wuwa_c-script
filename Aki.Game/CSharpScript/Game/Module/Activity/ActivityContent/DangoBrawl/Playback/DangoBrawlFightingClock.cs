using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x020057B6 RID: 22454
	public class DangoBrawlFightingClock
	{
		// Token: 0x06037738 RID: 227128 RVA: 0x00F7F294 File Offset: 0x00F7D494
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

		// Token: 0x17006ACE RID: 27342
		// (get) Token: 0x06037739 RID: 227129 RVA: 0x00F7F2E4 File Offset: 0x00F7D4E4
		public float Elapsed
		{
			get
			{
				return this.ElapsedMs;
			}
		}

		// Token: 0x17006ACF RID: 27343
		// (get) Token: 0x0603773A RID: 227130 RVA: 0x00F7F2EC File Offset: 0x00F7D4EC
		public float FightingElapsed
		{
			get
			{
				return this.FightingElapsedMs;
			}
		}

		// Token: 0x0401D434 RID: 119860
		private float ElapsedMs;

		// Token: 0x0401D435 RID: 119861
		private float FightingElapsedMs;
	}
}
