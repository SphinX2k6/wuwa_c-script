using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FDD RID: 24541
	public class TetrisGemProgressData : ITetrisGemProgressData
	{
		// Token: 0x1700902F RID: 36911
		// (get) Token: 0x0603E2D8 RID: 254680 RVA: 0x00F02C86 File Offset: 0x00F00E86
		// (set) Token: 0x0603E2D9 RID: 254681 RVA: 0x00F02C8E File Offset: 0x00F00E8E
		public int GemId { get; set; }

		// Token: 0x17009030 RID: 36912
		// (get) Token: 0x0603E2DA RID: 254682 RVA: 0x00F02C97 File Offset: 0x00F00E97
		// (set) Token: 0x0603E2DB RID: 254683 RVA: 0x00F02C9F File Offset: 0x00F00E9F
		public int CurrentGemCount { get; set; }

		// Token: 0x17009031 RID: 36913
		// (get) Token: 0x0603E2DC RID: 254684 RVA: 0x00F02CA8 File Offset: 0x00F00EA8
		// (set) Token: 0x0603E2DD RID: 254685 RVA: 0x00F02CB0 File Offset: 0x00F00EB0
		public int TargetGemCount { get; set; }
	}
}
