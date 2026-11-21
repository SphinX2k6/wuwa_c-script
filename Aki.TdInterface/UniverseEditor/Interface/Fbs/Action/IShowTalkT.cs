using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B8 RID: 30904
	public class IShowTalkT
	{
		// Token: 0x1700E2BE RID: 58046
		// (get) Token: 0x06036667 RID: 222823 RVA: 0x00749058 File Offset: 0x00747258
		// (set) Token: 0x06036668 RID: 222824 RVA: 0x00749060 File Offset: 0x00747260
		public bool ResetCamera { get; set; }

		// Token: 0x1700E2BF RID: 58047
		// (get) Token: 0x06036669 RID: 222825 RVA: 0x00749069 File Offset: 0x00747269
		// (set) Token: 0x0603666A RID: 222826 RVA: 0x00749071 File Offset: 0x00747271
		public List<ITalkItem_UnionUnion> TalkItems { get; set; }

		// Token: 0x1700E2C0 RID: 58048
		// (get) Token: 0x0603666B RID: 222827 RVA: 0x0074907A File Offset: 0x0074727A
		// (set) Token: 0x0603666C RID: 222828 RVA: 0x00749082 File Offset: 0x00747282
		public IShowTalkOutlineT TalkOutline { get; set; }

		// Token: 0x1700E2C1 RID: 58049
		// (get) Token: 0x0603666D RID: 222829 RVA: 0x0074908B File Offset: 0x0074728B
		// (set) Token: 0x0603666E RID: 222830 RVA: 0x00749093 File Offset: 0x00747293
		public string SequenceDataAsset { get; set; }

		// Token: 0x1700E2C2 RID: 58050
		// (get) Token: 0x0603666F RID: 222831 RVA: 0x0074909C File Offset: 0x0074729C
		// (set) Token: 0x06036670 RID: 222832 RVA: 0x007490A4 File Offset: 0x007472A4
		public List<IShowTalkFrameEventT> TalkFrameEvents { get; set; }

		// Token: 0x1700E2C3 RID: 58051
		// (get) Token: 0x06036671 RID: 222833 RVA: 0x007490AD File Offset: 0x007472AD
		// (set) Token: 0x06036672 RID: 222834 RVA: 0x007490B5 File Offset: 0x007472B5
		public List<IShowTalk_TalkSequenceRowT> TalkSequence { get; set; }

		// Token: 0x1700E2C4 RID: 58052
		// (get) Token: 0x06036673 RID: 222835 RVA: 0x007490BE File Offset: 0x007472BE
		// (set) Token: 0x06036674 RID: 222836 RVA: 0x007490C6 File Offset: 0x007472C6
		public List<string> SequenceNames { get; set; }

		// Token: 0x1700E2C5 RID: 58053
		// (get) Token: 0x06036675 RID: 222837 RVA: 0x007490CF File Offset: 0x007472CF
		// (set) Token: 0x06036676 RID: 222838 RVA: 0x007490D7 File Offset: 0x007472D7
		public List<Record_Int_ITalkSequenceTransitionsT> SequenceTransitions { get; set; }

		// Token: 0x1700E2C6 RID: 58054
		// (get) Token: 0x06036677 RID: 222839 RVA: 0x007490E0 File Offset: 0x007472E0
		// (set) Token: 0x06036678 RID: 222840 RVA: 0x007490E8 File Offset: 0x007472E8
		public bool SaveFinalPos { get; set; }

		// Token: 0x1700E2C7 RID: 58055
		// (get) Token: 0x06036679 RID: 222841 RVA: 0x007490F1 File Offset: 0x007472F1
		// (set) Token: 0x0603667A RID: 222842 RVA: 0x007490F9 File Offset: 0x007472F9
		public ISetBlendAnimT SeqBlendAnim { get; set; }

		// Token: 0x1700E2C8 RID: 58056
		// (get) Token: 0x0603667B RID: 222843 RVA: 0x00749102 File Offset: 0x00747302
		// (set) Token: 0x0603667C RID: 222844 RVA: 0x0074910A File Offset: 0x0074730A
		public byte NullMask { get; set; }

		// Token: 0x0603667D RID: 222845 RVA: 0x00749114 File Offset: 0x00747314
		public IShowTalkT()
		{
			this.ResetCamera = false;
			this.TalkItems = null;
			this.TalkOutline = null;
			this.SequenceDataAsset = null;
			this.TalkFrameEvents = null;
			this.TalkSequence = null;
			this.SequenceNames = null;
			this.SequenceTransitions = null;
			this.SaveFinalPos = false;
			this.SeqBlendAnim = null;
			this.NullMask = 0;
		}
	}
}
