using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064AB RID: 25771
	public class ICommonTipReachChallengeT
	{
		// Token: 0x1700BFC6 RID: 49094
		// (get) Token: 0x0602CABA RID: 182970 RVA: 0x00621B73 File Offset: 0x0061FD73
		// (set) Token: 0x0602CABB RID: 182971 RVA: 0x00621B7B File Offset: 0x0061FD7B
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFC7 RID: 49095
		// (get) Token: 0x0602CABC RID: 182972 RVA: 0x00621B84 File Offset: 0x0061FD84
		// (set) Token: 0x0602CABD RID: 182973 RVA: 0x00621B8C File Offset: 0x0061FD8C
		public string TidMainText { get; set; }

		// Token: 0x0602CABE RID: 182974 RVA: 0x00621B95 File Offset: 0x0061FD95
		public ICommonTipReachChallengeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
