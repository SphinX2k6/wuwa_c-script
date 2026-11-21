using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF2 RID: 19698
	public class INodeBreakPointT
	{
		// Token: 0x17008CFD RID: 36093
		// (get) Token: 0x0601E79B RID: 124827 RVA: 0x00444CCE File Offset: 0x00442ECE
		// (set) Token: 0x0601E79C RID: 124828 RVA: 0x00444CD6 File Offset: 0x00442ED6
		public bool Before { get; set; }

		// Token: 0x17008CFE RID: 36094
		// (get) Token: 0x0601E79D RID: 124829 RVA: 0x00444CDF File Offset: 0x00442EDF
		// (set) Token: 0x0601E79E RID: 124830 RVA: 0x00444CE7 File Offset: 0x00442EE7
		public bool After { get; set; }

		// Token: 0x17008CFF RID: 36095
		// (get) Token: 0x0601E79F RID: 124831 RVA: 0x00444CF0 File Offset: 0x00442EF0
		// (set) Token: 0x0601E7A0 RID: 124832 RVA: 0x00444CF8 File Offset: 0x00442EF8
		public byte NullMask { get; set; }

		// Token: 0x0601E7A1 RID: 124833 RVA: 0x00444D01 File Offset: 0x00442F01
		public INodeBreakPointT()
		{
			this.Before = false;
			this.After = false;
			this.NullMask = 0;
		}
	}
}
