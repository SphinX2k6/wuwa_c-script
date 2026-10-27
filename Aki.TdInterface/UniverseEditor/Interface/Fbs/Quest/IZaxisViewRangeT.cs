using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B1 RID: 17073
	public class IZaxisViewRangeT
	{
		// Token: 0x1700792A RID: 31018
		// (get) Token: 0x060194C5 RID: 103621 RVA: 0x003A1C1A File Offset: 0x0039FE1A
		// (set) Token: 0x060194C6 RID: 103622 RVA: 0x003A1C22 File Offset: 0x0039FE22
		public int Up { get; set; }

		// Token: 0x1700792B RID: 31019
		// (get) Token: 0x060194C7 RID: 103623 RVA: 0x003A1C2B File Offset: 0x0039FE2B
		// (set) Token: 0x060194C8 RID: 103624 RVA: 0x003A1C33 File Offset: 0x0039FE33
		public int Down { get; set; }

		// Token: 0x1700792C RID: 31020
		// (get) Token: 0x060194C9 RID: 103625 RVA: 0x003A1C3C File Offset: 0x0039FE3C
		// (set) Token: 0x060194CA RID: 103626 RVA: 0x003A1C44 File Offset: 0x0039FE44
		public byte NullMask { get; set; }

		// Token: 0x060194CB RID: 103627 RVA: 0x003A1C4D File Offset: 0x0039FE4D
		public IZaxisViewRangeT()
		{
			this.Up = 0;
			this.Down = 0;
			this.NullMask = 0;
		}
	}
}
