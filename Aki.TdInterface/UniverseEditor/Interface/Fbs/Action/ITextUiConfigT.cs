using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D4 RID: 29652
	public class ITextUiConfigT
	{
		// Token: 0x1700E144 RID: 57668
		// (get) Token: 0x06035DED RID: 220653 RVA: 0x00755398 File Offset: 0x00753598
		// (set) Token: 0x06035DEE RID: 220654 RVA: 0x007553A0 File Offset: 0x007535A0
		public ETextUiType Type { get; set; }

		// Token: 0x1700E145 RID: 57669
		// (get) Token: 0x06035DEF RID: 220655 RVA: 0x007553A9 File Offset: 0x007535A9
		// (set) Token: 0x06035DF0 RID: 220656 RVA: 0x007553B1 File Offset: 0x007535B1
		public string InitTipText { get; set; }

		// Token: 0x1700E146 RID: 57670
		// (get) Token: 0x06035DF1 RID: 220657 RVA: 0x007553BA File Offset: 0x007535BA
		// (set) Token: 0x06035DF2 RID: 220658 RVA: 0x007553C2 File Offset: 0x007535C2
		public string ProgressTipText { get; set; }

		// Token: 0x1700E147 RID: 57671
		// (get) Token: 0x06035DF3 RID: 220659 RVA: 0x007553CB File Offset: 0x007535CB
		// (set) Token: 0x06035DF4 RID: 220660 RVA: 0x007553D3 File Offset: 0x007535D3
		public string SkipText { get; set; }

		// Token: 0x1700E148 RID: 57672
		// (get) Token: 0x06035DF5 RID: 220661 RVA: 0x007553DC File Offset: 0x007535DC
		// (set) Token: 0x06035DF6 RID: 220662 RVA: 0x007553E4 File Offset: 0x007535E4
		public string FinishText { get; set; }

		// Token: 0x1700E149 RID: 57673
		// (get) Token: 0x06035DF7 RID: 220663 RVA: 0x007553ED File Offset: 0x007535ED
		// (set) Token: 0x06035DF8 RID: 220664 RVA: 0x007553F5 File Offset: 0x007535F5
		public List<string> InitDialogues { get; set; }

		// Token: 0x1700E14A RID: 57674
		// (get) Token: 0x06035DF9 RID: 220665 RVA: 0x007553FE File Offset: 0x007535FE
		// (set) Token: 0x06035DFA RID: 220666 RVA: 0x00755406 File Offset: 0x00753606
		public int SkipConfirmBoxId { get; set; }

		// Token: 0x1700E14B RID: 57675
		// (get) Token: 0x06035DFB RID: 220667 RVA: 0x0075540F File Offset: 0x0075360F
		// (set) Token: 0x06035DFC RID: 220668 RVA: 0x00755417 File Offset: 0x00753617
		public string LoopAudioEvent { get; set; }

		// Token: 0x1700E14C RID: 57676
		// (get) Token: 0x06035DFD RID: 220669 RVA: 0x00755420 File Offset: 0x00753620
		// (set) Token: 0x06035DFE RID: 220670 RVA: 0x00755428 File Offset: 0x00753628
		public byte NullMask { get; set; }

		// Token: 0x06035DFF RID: 220671 RVA: 0x00755434 File Offset: 0x00753634
		public ITextUiConfigT()
		{
			this.Type = ETextUiType.Astrology;
			this.InitTipText = null;
			this.ProgressTipText = null;
			this.SkipText = null;
			this.FinishText = null;
			this.InitDialogues = null;
			this.SkipConfirmBoxId = 0;
			this.LoopAudioEvent = null;
			this.NullMask = 0;
		}
	}
}
