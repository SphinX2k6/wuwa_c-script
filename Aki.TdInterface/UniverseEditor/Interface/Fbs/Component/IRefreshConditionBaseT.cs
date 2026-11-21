using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E22 RID: 24098
	public class IRefreshConditionBaseT
	{
		// Token: 0x1700B1A3 RID: 45475
		// (get) Token: 0x060283FC RID: 164860 RVA: 0x00580FA2 File Offset: 0x0057F1A2
		// (set) Token: 0x060283FD RID: 164861 RVA: 0x00580FAA File Offset: 0x0057F1AA
		public ERewardDropType Type { get; set; }

		// Token: 0x060283FE RID: 164862 RVA: 0x00580FB3 File Offset: 0x0057F1B3
		public IRefreshConditionBaseT()
		{
			this.Type = ERewardDropType.Death;
		}
	}
}
