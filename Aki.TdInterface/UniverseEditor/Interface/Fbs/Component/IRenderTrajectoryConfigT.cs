using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E63 RID: 24163
	public class IRenderTrajectoryConfigT
	{
		// Token: 0x1700B22E RID: 45614
		// (get) Token: 0x06028665 RID: 165477 RVA: 0x005861F7 File Offset: 0x005843F7
		// (set) Token: 0x06028666 RID: 165478 RVA: 0x005861FF File Offset: 0x005843FF
		public float Time { get; set; }

		// Token: 0x1700B22F RID: 45615
		// (get) Token: 0x06028667 RID: 165479 RVA: 0x00586208 File Offset: 0x00584408
		// (set) Token: 0x06028668 RID: 165480 RVA: 0x00586210 File Offset: 0x00584410
		public string Effect { get; set; }

		// Token: 0x06028669 RID: 165481 RVA: 0x00586219 File Offset: 0x00584419
		public IRenderTrajectoryConfigT()
		{
			this.Time = 0f;
			this.Effect = null;
		}
	}
}
