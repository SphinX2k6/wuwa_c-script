using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006490 RID: 25744
	public class ICommonTipChallengeFailT
	{
		// Token: 0x1700BF97 RID: 49047
		// (get) Token: 0x0602C9E0 RID: 182752 RVA: 0x0062074F File Offset: 0x0061E94F
		// (set) Token: 0x0602C9E1 RID: 182753 RVA: 0x00620757 File Offset: 0x0061E957
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BF98 RID: 49048
		// (get) Token: 0x0602C9E2 RID: 182754 RVA: 0x00620760 File Offset: 0x0061E960
		// (set) Token: 0x0602C9E3 RID: 182755 RVA: 0x00620768 File Offset: 0x0061E968
		public string TidMainText { get; set; }

		// Token: 0x0602C9E4 RID: 182756 RVA: 0x00620771 File Offset: 0x0061E971
		public ICommonTipChallengeFailT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
