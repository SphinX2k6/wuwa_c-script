using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FEC RID: 24556
	public class TetrisScoreSnapshot : ITetrisScoreSnapshot
	{
		// Token: 0x1700904E RID: 36942
		// (get) Token: 0x0603E37F RID: 254847 RVA: 0x00F05998 File Offset: 0x00F03B98
		// (set) Token: 0x0603E380 RID: 254848 RVA: 0x00F059A0 File Offset: 0x00F03BA0
		public int CurrentScore { get; set; }

		// Token: 0x1700904F RID: 36943
		// (get) Token: 0x0603E381 RID: 254849 RVA: 0x00F059A9 File Offset: 0x00F03BA9
		// (set) Token: 0x0603E382 RID: 254850 RVA: 0x00F059B1 File Offset: 0x00F03BB1
		public int LastClearTurn { get; set; }

		// Token: 0x17009050 RID: 36944
		// (get) Token: 0x0603E383 RID: 254851 RVA: 0x00F059BA File Offset: 0x00F03BBA
		// (set) Token: 0x0603E384 RID: 254852 RVA: 0x00F059C2 File Offset: 0x00F03BC2
		public int ComboCount { get; set; }

		// Token: 0x17009051 RID: 36945
		// (get) Token: 0x0603E385 RID: 254853 RVA: 0x00F059CB File Offset: 0x00F03BCB
		// (set) Token: 0x0603E386 RID: 254854 RVA: 0x00F059D3 File Offset: 0x00F03BD3
		public int MaxComboCount { get; set; }
	}
}
