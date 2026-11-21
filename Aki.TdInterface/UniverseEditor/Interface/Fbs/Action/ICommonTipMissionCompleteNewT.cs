using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B10 RID: 27408
	public class ICommonTipMissionCompleteNewT
	{
		// Token: 0x1700C94A RID: 51530
		// (get) Token: 0x0602F208 RID: 193032 RVA: 0x0066D375 File Offset: 0x0066B575
		// (set) Token: 0x0602F209 RID: 193033 RVA: 0x0066D37D File Offset: 0x0066B57D
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C94B RID: 51531
		// (get) Token: 0x0602F20A RID: 193034 RVA: 0x0066D386 File Offset: 0x0066B586
		// (set) Token: 0x0602F20B RID: 193035 RVA: 0x0066D38E File Offset: 0x0066B58E
		public EQuestCommonTipType QuestType { get; set; }

		// Token: 0x1700C94C RID: 51532
		// (get) Token: 0x0602F20C RID: 193036 RVA: 0x0066D397 File Offset: 0x0066B597
		// (set) Token: 0x0602F20D RID: 193037 RVA: 0x0066D39F File Offset: 0x0066B59F
		public string TipTextKey { get; set; }

		// Token: 0x0602F20E RID: 193038 RVA: 0x0066D3A8 File Offset: 0x0066B5A8
		public ICommonTipMissionCompleteNewT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.QuestType = EQuestCommonTipType.Branch;
			this.TipTextKey = null;
		}
	}
}
