using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BD RID: 26813
	public class IBvbPlayerOperationConstraintT
	{
		// Token: 0x1700C515 RID: 50453
		// (get) Token: 0x0602DDC1 RID: 187841 RVA: 0x0064451F File Offset: 0x0064271F
		// (set) Token: 0x0602DDC2 RID: 187842 RVA: 0x00644527 File Offset: 0x00642727
		public TBvbPlayerOperationTypeUnion EnableOperation { get; set; }

		// Token: 0x1700C516 RID: 50454
		// (get) Token: 0x0602DDC3 RID: 187843 RVA: 0x00644530 File Offset: 0x00642730
		// (set) Token: 0x0602DDC4 RID: 187844 RVA: 0x00644538 File Offset: 0x00642738
		public bool IsTheLast { get; set; }

		// Token: 0x1700C517 RID: 50455
		// (get) Token: 0x0602DDC5 RID: 187845 RVA: 0x00644541 File Offset: 0x00642741
		// (set) Token: 0x0602DDC6 RID: 187846 RVA: 0x00644549 File Offset: 0x00642749
		public string TidPromptTxt { get; set; }

		// Token: 0x1700C518 RID: 50456
		// (get) Token: 0x0602DDC7 RID: 187847 RVA: 0x00644552 File Offset: 0x00642752
		// (set) Token: 0x0602DDC8 RID: 187848 RVA: 0x0064455A File Offset: 0x0064275A
		public byte NullMask { get; set; }

		// Token: 0x0602DDC9 RID: 187849 RVA: 0x00644563 File Offset: 0x00642763
		public IBvbPlayerOperationConstraintT()
		{
			this.EnableOperation = null;
			this.IsTheLast = false;
			this.TidPromptTxt = null;
			this.NullMask = 0;
		}
	}
}
