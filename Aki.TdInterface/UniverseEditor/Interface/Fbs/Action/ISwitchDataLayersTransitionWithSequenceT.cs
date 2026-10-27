using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007257 RID: 29271
	public class ISwitchDataLayersTransitionWithSequenceT
	{
		// Token: 0x1700D92F RID: 55599
		// (get) Token: 0x06033EC8 RID: 212680 RVA: 0x006FBE68 File Offset: 0x006FA068
		// (set) Token: 0x06033EC9 RID: 212681 RVA: 0x006FBE70 File Offset: 0x006FA070
		public ESwitchDataLayersTransitionType Type { get; set; }

		// Token: 0x1700D930 RID: 55600
		// (get) Token: 0x06033ECA RID: 212682 RVA: 0x006FBE79 File Offset: 0x006FA079
		// (set) Token: 0x06033ECB RID: 212683 RVA: 0x006FBE81 File Offset: 0x006FA081
		public string SequencePath { get; set; }

		// Token: 0x1700D931 RID: 55601
		// (get) Token: 0x06033ECC RID: 212684 RVA: 0x006FBE8A File Offset: 0x006FA08A
		// (set) Token: 0x06033ECD RID: 212685 RVA: 0x006FBE92 File Offset: 0x006FA092
		public string SeqMarkBeforeModifyMat { get; set; }

		// Token: 0x06033ECE RID: 212686 RVA: 0x006FBE9B File Offset: 0x006FA09B
		public ISwitchDataLayersTransitionWithSequenceT()
		{
			this.Type = ESwitchDataLayersTransitionType.Sequence;
			this.SequencePath = null;
			this.SeqMarkBeforeModifyMat = null;
		}
	}
}
