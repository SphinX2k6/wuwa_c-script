using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD7 RID: 24535
	public class RoundConfig : IRoundConfig
	{
		// Token: 0x1700901B RID: 36891
		// (get) Token: 0x0603E2AD RID: 254637 RVA: 0x00F02BA2 File Offset: 0x00F00DA2
		// (set) Token: 0x0603E2AE RID: 254638 RVA: 0x00F02BAA File Offset: 0x00F00DAA
		public int Id { get; set; }

		// Token: 0x1700901C RID: 36892
		// (get) Token: 0x0603E2AF RID: 254639 RVA: 0x00F02BB3 File Offset: 0x00F00DB3
		// (set) Token: 0x0603E2B0 RID: 254640 RVA: 0x00F02BBB File Offset: 0x00F00DBB
		public int LevelId { get; set; }

		// Token: 0x1700901D RID: 36893
		// (get) Token: 0x0603E2B1 RID: 254641 RVA: 0x00F02BC4 File Offset: 0x00F00DC4
		// (set) Token: 0x0603E2B2 RID: 254642 RVA: 0x00F02BCC File Offset: 0x00F00DCC
		public int Round { get; set; }

		// Token: 0x1700901E RID: 36894
		// (get) Token: 0x0603E2B3 RID: 254643 RVA: 0x00F02BD5 File Offset: 0x00F00DD5
		// (set) Token: 0x0603E2B4 RID: 254644 RVA: 0x00F02BDD File Offset: 0x00F00DDD
		public int ShapeId { get; set; }

		// Token: 0x1700901F RID: 36895
		// (get) Token: 0x0603E2B5 RID: 254645 RVA: 0x00F02BE6 File Offset: 0x00F00DE6
		// (set) Token: 0x0603E2B6 RID: 254646 RVA: 0x00F02BEE File Offset: 0x00F00DEE
		public int Color { get; set; }

		// Token: 0x17009020 RID: 36896
		// (get) Token: 0x0603E2B7 RID: 254647 RVA: 0x00F02BF7 File Offset: 0x00F00DF7
		// (set) Token: 0x0603E2B8 RID: 254648 RVA: 0x00F02BFF File Offset: 0x00F00DFF
		public int Gem { get; set; }

		// Token: 0x17009021 RID: 36897
		// (get) Token: 0x0603E2B9 RID: 254649 RVA: 0x00F02C08 File Offset: 0x00F00E08
		// (set) Token: 0x0603E2BA RID: 254650 RVA: 0x00F02C10 File Offset: 0x00F00E10
		public int GemFill { get; set; }
	}
}
