using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A5 RID: 25765
	public class ICommonTipMissionCompleteNewT
	{
		// Token: 0x1700BFBD RID: 49085
		// (get) Token: 0x0602CA8E RID: 182926 RVA: 0x006217A1 File Offset: 0x0061F9A1
		// (set) Token: 0x0602CA8F RID: 182927 RVA: 0x006217A9 File Offset: 0x0061F9A9
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFBE RID: 49086
		// (get) Token: 0x0602CA90 RID: 182928 RVA: 0x006217B2 File Offset: 0x0061F9B2
		// (set) Token: 0x0602CA91 RID: 182929 RVA: 0x006217BA File Offset: 0x0061F9BA
		public EQuestCommonTipType QuestType { get; set; }

		// Token: 0x1700BFBF RID: 49087
		// (get) Token: 0x0602CA92 RID: 182930 RVA: 0x006217C3 File Offset: 0x0061F9C3
		// (set) Token: 0x0602CA93 RID: 182931 RVA: 0x006217CB File Offset: 0x0061F9CB
		public string TipTextKey { get; set; }

		// Token: 0x0602CA94 RID: 182932 RVA: 0x006217D4 File Offset: 0x0061F9D4
		public ICommonTipMissionCompleteNewT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.QuestType = EQuestCommonTipType.Branch;
			this.TipTextKey = null;
		}
	}
}
