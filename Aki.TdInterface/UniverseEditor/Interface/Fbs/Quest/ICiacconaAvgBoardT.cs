using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D8F RID: 15759
	public class ICiacconaAvgBoardT
	{
		// Token: 0x17006C5C RID: 27740
		// (get) Token: 0x06015E1A RID: 89626 RVA: 0x00328FE6 File Offset: 0x003271E6
		// (set) Token: 0x06015E1B RID: 89627 RVA: 0x00328FEE File Offset: 0x003271EE
		public EShowUiType Type { get; set; }

		// Token: 0x17006C5D RID: 27741
		// (get) Token: 0x06015E1C RID: 89628 RVA: 0x00328FF7 File Offset: 0x003271F7
		// (set) Token: 0x06015E1D RID: 89629 RVA: 0x00328FFF File Offset: 0x003271FF
		public int EndingId { get; set; }

		// Token: 0x17006C5E RID: 27742
		// (get) Token: 0x06015E1E RID: 89630 RVA: 0x00329008 File Offset: 0x00327208
		// (set) Token: 0x06015E1F RID: 89631 RVA: 0x00329010 File Offset: 0x00327210
		public byte NullMask { get; set; }

		// Token: 0x06015E20 RID: 89632 RVA: 0x00329019 File Offset: 0x00327219
		public ICiacconaAvgBoardT()
		{
			this.Type = EShowUiType.All;
			this.EndingId = 0;
			this.NullMask = 0;
		}
	}
}
