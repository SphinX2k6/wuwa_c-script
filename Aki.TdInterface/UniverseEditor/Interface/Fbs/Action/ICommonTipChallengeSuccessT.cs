using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFE RID: 27390
	public class ICommonTipChallengeSuccessT
	{
		// Token: 0x1700C929 RID: 51497
		// (get) Token: 0x0602F172 RID: 192882 RVA: 0x0066C557 File Offset: 0x0066A757
		// (set) Token: 0x0602F173 RID: 192883 RVA: 0x0066C55F File Offset: 0x0066A75F
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C92A RID: 51498
		// (get) Token: 0x0602F174 RID: 192884 RVA: 0x0066C568 File Offset: 0x0066A768
		// (set) Token: 0x0602F175 RID: 192885 RVA: 0x0066C570 File Offset: 0x0066A770
		public string TidMainText { get; set; }

		// Token: 0x0602F176 RID: 192886 RVA: 0x0066C579 File Offset: 0x0066A779
		public ICommonTipChallengeSuccessT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
