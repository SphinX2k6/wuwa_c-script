using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FEB RID: 24555
	public interface ITetrisScoreSnapshot
	{
		// Token: 0x1700904A RID: 36938
		// (get) Token: 0x0603E377 RID: 254839
		// (set) Token: 0x0603E378 RID: 254840
		int CurrentScore { get; set; }

		// Token: 0x1700904B RID: 36939
		// (get) Token: 0x0603E379 RID: 254841
		// (set) Token: 0x0603E37A RID: 254842
		int LastClearTurn { get; set; }

		// Token: 0x1700904C RID: 36940
		// (get) Token: 0x0603E37B RID: 254843
		// (set) Token: 0x0603E37C RID: 254844
		int ComboCount { get; set; }

		// Token: 0x1700904D RID: 36941
		// (get) Token: 0x0603E37D RID: 254845
		// (set) Token: 0x0603E37E RID: 254846
		int MaxComboCount { get; set; }
	}
}
