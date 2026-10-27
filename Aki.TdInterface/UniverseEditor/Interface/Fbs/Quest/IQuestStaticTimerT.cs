using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200404A RID: 16458
	public class IQuestStaticTimerT
	{
		// Token: 0x170073D6 RID: 29654
		// (get) Token: 0x06017D65 RID: 97637 RVA: 0x00370509 File Offset: 0x0036E709
		// (set) Token: 0x06017D66 RID: 97638 RVA: 0x00370511 File Offset: 0x0036E711
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170073D7 RID: 29655
		// (get) Token: 0x06017D67 RID: 97639 RVA: 0x0037051A File Offset: 0x0036E71A
		// (set) Token: 0x06017D68 RID: 97640 RVA: 0x00370522 File Offset: 0x0036E722
		public TVarRefUnion Var { get; set; }

		// Token: 0x170073D8 RID: 29656
		// (get) Token: 0x06017D69 RID: 97641 RVA: 0x0037052B File Offset: 0x0036E72B
		// (set) Token: 0x06017D6A RID: 97642 RVA: 0x00370533 File Offset: 0x0036E733
		public ETimerType TimerType { get; set; }

		// Token: 0x06017D6B RID: 97643 RVA: 0x0037053C File Offset: 0x0036E73C
		public IQuestStaticTimerT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.TimerType = ETimerType.CountDownChallenge;
		}
	}
}
