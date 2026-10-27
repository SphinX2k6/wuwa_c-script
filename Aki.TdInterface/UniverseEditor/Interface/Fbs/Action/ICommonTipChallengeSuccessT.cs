using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006493 RID: 25747
	public class ICommonTipChallengeSuccessT
	{
		// Token: 0x1700BF9C RID: 49052
		// (get) Token: 0x0602C9F8 RID: 182776 RVA: 0x00620983 File Offset: 0x0061EB83
		// (set) Token: 0x0602C9F9 RID: 182777 RVA: 0x0062098B File Offset: 0x0061EB8B
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BF9D RID: 49053
		// (get) Token: 0x0602C9FA RID: 182778 RVA: 0x00620994 File Offset: 0x0061EB94
		// (set) Token: 0x0602C9FB RID: 182779 RVA: 0x0062099C File Offset: 0x0061EB9C
		public string TidMainText { get; set; }

		// Token: 0x0602C9FC RID: 182780 RVA: 0x006209A5 File Offset: 0x0061EBA5
		public ICommonTipChallengeSuccessT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
