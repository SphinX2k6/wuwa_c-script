using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A2C RID: 31276
	public class ISwitchDataLayersTransitionWithSequenceT
	{
		// Token: 0x1700E528 RID: 58664
		// (get) Token: 0x060371CA RID: 225738 RVA: 0x0075D1C8 File Offset: 0x0075B3C8
		// (set) Token: 0x060371CB RID: 225739 RVA: 0x0075D1D0 File Offset: 0x0075B3D0
		public ESwitchDataLayersTransitionType Type { get; set; }

		// Token: 0x1700E529 RID: 58665
		// (get) Token: 0x060371CC RID: 225740 RVA: 0x0075D1D9 File Offset: 0x0075B3D9
		// (set) Token: 0x060371CD RID: 225741 RVA: 0x0075D1E1 File Offset: 0x0075B3E1
		public string SequencePath { get; set; }

		// Token: 0x1700E52A RID: 58666
		// (get) Token: 0x060371CE RID: 225742 RVA: 0x0075D1EA File Offset: 0x0075B3EA
		// (set) Token: 0x060371CF RID: 225743 RVA: 0x0075D1F2 File Offset: 0x0075B3F2
		public string SeqMarkBeforeModifyMat { get; set; }

		// Token: 0x060371D0 RID: 225744 RVA: 0x0075D1FB File Offset: 0x0075B3FB
		public ISwitchDataLayersTransitionWithSequenceT()
		{
			this.Type = ESwitchDataLayersTransitionType.Sequence;
			this.SequencePath = null;
			this.SeqMarkBeforeModifyMat = null;
		}
	}
}
