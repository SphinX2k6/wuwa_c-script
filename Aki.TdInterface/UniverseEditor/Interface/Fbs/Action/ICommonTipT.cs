using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200647E RID: 25726
	public class ICommonTipT
	{
		// Token: 0x1700BF74 RID: 49012
		// (get) Token: 0x0602C94E RID: 182606 RVA: 0x0061F8C7 File Offset: 0x0061DAC7
		// (set) Token: 0x0602C94F RID: 182607 RVA: 0x0061F8CF File Offset: 0x0061DACF
		public TCommonTipOptionUnion TipOption { get; set; }

		// Token: 0x1700BF75 RID: 49013
		// (get) Token: 0x0602C950 RID: 182608 RVA: 0x0061F8D8 File Offset: 0x0061DAD8
		// (set) Token: 0x0602C951 RID: 182609 RVA: 0x0061F8E0 File Offset: 0x0061DAE0
		public int Duration { get; set; }

		// Token: 0x1700BF76 RID: 49014
		// (get) Token: 0x0602C952 RID: 182610 RVA: 0x0061F8E9 File Offset: 0x0061DAE9
		// (set) Token: 0x0602C953 RID: 182611 RVA: 0x0061F8F1 File Offset: 0x0061DAF1
		public string Token { get; set; }

		// Token: 0x1700BF77 RID: 49015
		// (get) Token: 0x0602C954 RID: 182612 RVA: 0x0061F8FA File Offset: 0x0061DAFA
		// (set) Token: 0x0602C955 RID: 182613 RVA: 0x0061F902 File Offset: 0x0061DB02
		public byte NullMask { get; set; }

		// Token: 0x0602C956 RID: 182614 RVA: 0x0061F90B File Offset: 0x0061DB0B
		public ICommonTipT()
		{
			this.TipOption = null;
			this.Duration = 0;
			this.Token = null;
			this.NullMask = 0;
		}
	}
}
