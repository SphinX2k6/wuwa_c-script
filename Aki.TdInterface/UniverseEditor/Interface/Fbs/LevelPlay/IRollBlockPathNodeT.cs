using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A11 RID: 18961
	public class IRollBlockPathNodeT
	{
		// Token: 0x17008501 RID: 34049
		// (get) Token: 0x0601C734 RID: 116532 RVA: 0x004049CC File Offset: 0x00402BCC
		// (set) Token: 0x0601C735 RID: 116533 RVA: 0x004049D4 File Offset: 0x00402BD4
		public int X { get; set; }

		// Token: 0x17008502 RID: 34050
		// (get) Token: 0x0601C736 RID: 116534 RVA: 0x004049DD File Offset: 0x00402BDD
		// (set) Token: 0x0601C737 RID: 116535 RVA: 0x004049E5 File Offset: 0x00402BE5
		public int Y { get; set; }

		// Token: 0x0601C738 RID: 116536 RVA: 0x004049EE File Offset: 0x00402BEE
		public IRollBlockPathNodeT()
		{
			this.X = 0;
			this.Y = 0;
		}
	}
}
