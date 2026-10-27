using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FDC RID: 24540
	public interface ITetrisGemProgressData
	{
		// Token: 0x1700902C RID: 36908
		// (get) Token: 0x0603E2D2 RID: 254674
		// (set) Token: 0x0603E2D3 RID: 254675
		int GemId { get; set; }

		// Token: 0x1700902D RID: 36909
		// (get) Token: 0x0603E2D4 RID: 254676
		// (set) Token: 0x0603E2D5 RID: 254677
		int CurrentGemCount { get; set; }

		// Token: 0x1700902E RID: 36910
		// (get) Token: 0x0603E2D6 RID: 254678
		// (set) Token: 0x0603E2D7 RID: 254679
		int TargetGemCount { get; set; }
	}
}
