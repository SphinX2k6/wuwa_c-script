using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FDF RID: 24543
	public class TetrisGemGetData : ITetrisGemGetData
	{
		// Token: 0x17009034 RID: 36916
		// (get) Token: 0x0603E2E3 RID: 254691 RVA: 0x00F02CC1 File Offset: 0x00F00EC1
		// (set) Token: 0x0603E2E4 RID: 254692 RVA: 0x00F02CC9 File Offset: 0x00F00EC9
		public int GemId { get; set; }

		// Token: 0x17009035 RID: 36917
		// (get) Token: 0x0603E2E5 RID: 254693 RVA: 0x00F02CD2 File Offset: 0x00F00ED2
		// (set) Token: 0x0603E2E6 RID: 254694 RVA: 0x00F02CDA File Offset: 0x00F00EDA
		public int GetGemCount { get; set; }
	}
}
