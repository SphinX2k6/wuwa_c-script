using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFB RID: 27387
	public class ICommonTipChallengeFailT
	{
		// Token: 0x1700C924 RID: 51492
		// (get) Token: 0x0602F15A RID: 192858 RVA: 0x0066C323 File Offset: 0x0066A523
		// (set) Token: 0x0602F15B RID: 192859 RVA: 0x0066C32B File Offset: 0x0066A52B
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C925 RID: 51493
		// (get) Token: 0x0602F15C RID: 192860 RVA: 0x0066C334 File Offset: 0x0066A534
		// (set) Token: 0x0602F15D RID: 192861 RVA: 0x0066C33C File Offset: 0x0066A53C
		public string TidMainText { get; set; }

		// Token: 0x0602F15E RID: 192862 RVA: 0x0066C345 File Offset: 0x0066A545
		public ICommonTipChallengeFailT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
