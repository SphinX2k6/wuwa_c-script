using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EC RID: 28908
	public class IShowTalkT
	{
		// Token: 0x1700D6DB RID: 55003
		// (get) Token: 0x060333C5 RID: 209861 RVA: 0x006E8A4C File Offset: 0x006E6C4C
		// (set) Token: 0x060333C6 RID: 209862 RVA: 0x006E8A54 File Offset: 0x006E6C54
		public bool ResetCamera { get; set; }

		// Token: 0x1700D6DC RID: 55004
		// (get) Token: 0x060333C7 RID: 209863 RVA: 0x006E8A5D File Offset: 0x006E6C5D
		// (set) Token: 0x060333C8 RID: 209864 RVA: 0x006E8A65 File Offset: 0x006E6C65
		public List<ITalkItem_UnionUnion> TalkItems { get; set; }

		// Token: 0x1700D6DD RID: 55005
		// (get) Token: 0x060333C9 RID: 209865 RVA: 0x006E8A6E File Offset: 0x006E6C6E
		// (set) Token: 0x060333CA RID: 209866 RVA: 0x006E8A76 File Offset: 0x006E6C76
		public IShowTalkOutlineT TalkOutline { get; set; }

		// Token: 0x1700D6DE RID: 55006
		// (get) Token: 0x060333CB RID: 209867 RVA: 0x006E8A7F File Offset: 0x006E6C7F
		// (set) Token: 0x060333CC RID: 209868 RVA: 0x006E8A87 File Offset: 0x006E6C87
		public string SequenceDataAsset { get; set; }

		// Token: 0x1700D6DF RID: 55007
		// (get) Token: 0x060333CD RID: 209869 RVA: 0x006E8A90 File Offset: 0x006E6C90
		// (set) Token: 0x060333CE RID: 209870 RVA: 0x006E8A98 File Offset: 0x006E6C98
		public List<IShowTalkFrameEventT> TalkFrameEvents { get; set; }

		// Token: 0x1700D6E0 RID: 55008
		// (get) Token: 0x060333CF RID: 209871 RVA: 0x006E8AA1 File Offset: 0x006E6CA1
		// (set) Token: 0x060333D0 RID: 209872 RVA: 0x006E8AA9 File Offset: 0x006E6CA9
		public List<IShowTalk_TalkSequenceRowT> TalkSequence { get; set; }

		// Token: 0x1700D6E1 RID: 55009
		// (get) Token: 0x060333D1 RID: 209873 RVA: 0x006E8AB2 File Offset: 0x006E6CB2
		// (set) Token: 0x060333D2 RID: 209874 RVA: 0x006E8ABA File Offset: 0x006E6CBA
		public List<string> SequenceNames { get; set; }

		// Token: 0x1700D6E2 RID: 55010
		// (get) Token: 0x060333D3 RID: 209875 RVA: 0x006E8AC3 File Offset: 0x006E6CC3
		// (set) Token: 0x060333D4 RID: 209876 RVA: 0x006E8ACB File Offset: 0x006E6CCB
		public List<Record_Int_ITalkSequenceTransitionsT> SequenceTransitions { get; set; }

		// Token: 0x1700D6E3 RID: 55011
		// (get) Token: 0x060333D5 RID: 209877 RVA: 0x006E8AD4 File Offset: 0x006E6CD4
		// (set) Token: 0x060333D6 RID: 209878 RVA: 0x006E8ADC File Offset: 0x006E6CDC
		public bool SaveFinalPos { get; set; }

		// Token: 0x1700D6E4 RID: 55012
		// (get) Token: 0x060333D7 RID: 209879 RVA: 0x006E8AE5 File Offset: 0x006E6CE5
		// (set) Token: 0x060333D8 RID: 209880 RVA: 0x006E8AED File Offset: 0x006E6CED
		public ISetBlendAnimT SeqBlendAnim { get; set; }

		// Token: 0x1700D6E5 RID: 55013
		// (get) Token: 0x060333D9 RID: 209881 RVA: 0x006E8AF6 File Offset: 0x006E6CF6
		// (set) Token: 0x060333DA RID: 209882 RVA: 0x006E8AFE File Offset: 0x006E6CFE
		public byte NullMask { get; set; }

		// Token: 0x060333DB RID: 209883 RVA: 0x006E8B08 File Offset: 0x006E6D08
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
