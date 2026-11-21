using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E2E RID: 20014
	public class IBattleConditionT
	{
		// Token: 0x17008E92 RID: 36498
		// (get) Token: 0x0601EF35 RID: 126773 RVA: 0x00452C9A File Offset: 0x00450E9A
		// (set) Token: 0x0601EF36 RID: 126774 RVA: 0x00452CA2 File Offset: 0x00450EA2
		public EBattleConditionType Type { get; set; }

		// Token: 0x0601EF37 RID: 126775 RVA: 0x00452CAB File Offset: 0x00450EAB
		public IBattleConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
		}
	}
}
