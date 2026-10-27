using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FF2 RID: 24562
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGameSnapshot : ITetrisGameSnapshot
	{
		// Token: 0x17009060 RID: 36960
		// (get) Token: 0x0603E3B9 RID: 254905 RVA: 0x00F05EF1 File Offset: 0x00F040F1
		// (set) Token: 0x0603E3BA RID: 254906 RVA: 0x00F05EF9 File Offset: 0x00F040F9
		public TetrisCellData[][] BoardCells { get; set; }

		// Token: 0x17009061 RID: 36961
		// (get) Token: 0x0603E3BB RID: 254907 RVA: 0x00F05F02 File Offset: 0x00F04102
		// (set) Token: 0x0603E3BC RID: 254908 RVA: 0x00F05F0A File Offset: 0x00F0410A
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<BlockInstance> HandShapes { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x17009062 RID: 36962
		// (get) Token: 0x0603E3BD RID: 254909 RVA: 0x00F05F13 File Offset: 0x00F04113
		// (set) Token: 0x0603E3BE RID: 254910 RVA: 0x00F05F1B File Offset: 0x00F0411B
		public ITetrisScoreSnapshot ScoreSnapshot { get; set; }

		// Token: 0x17009063 RID: 36963
		// (get) Token: 0x0603E3BF RID: 254911 RVA: 0x00F05F24 File Offset: 0x00F04124
		// (set) Token: 0x0603E3C0 RID: 254912 RVA: 0x00F05F2C File Offset: 0x00F0412C
		public ITetrisGemSnapshot GemSnapshot { get; set; }

		// Token: 0x17009064 RID: 36964
		// (get) Token: 0x0603E3C1 RID: 254913 RVA: 0x00F05F35 File Offset: 0x00F04135
		// (set) Token: 0x0603E3C2 RID: 254914 RVA: 0x00F05F3D File Offset: 0x00F0413D
		public int CurrentRoundIndex { get; set; }

		// Token: 0x17009065 RID: 36965
		// (get) Token: 0x0603E3C3 RID: 254915 RVA: 0x00F05F46 File Offset: 0x00F04146
		// (set) Token: 0x0603E3C4 RID: 254916 RVA: 0x00F05F4E File Offset: 0x00F0414E
		public int CurrentStageIndex { get; set; }

		// Token: 0x17009066 RID: 36966
		// (get) Token: 0x0603E3C5 RID: 254917 RVA: 0x00F05F57 File Offset: 0x00F04157
		// (set) Token: 0x0603E3C6 RID: 254918 RVA: 0x00F05F5F File Offset: 0x00F0415F
		public int PlaceCount { get; set; }
	}
}
