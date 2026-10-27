using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D29 RID: 23849
	public class IBvbAiDiscardForEnergyAndActDataT
	{
		// Token: 0x1700B2C1 RID: 45761
		// (get) Token: 0x06028C3D RID: 166973 RVA: 0x005996E9 File Offset: 0x005978E9
		// (set) Token: 0x06028C3E RID: 166974 RVA: 0x005996F1 File Offset: 0x005978F1
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2C2 RID: 45762
		// (get) Token: 0x06028C3F RID: 166975 RVA: 0x005996FA File Offset: 0x005978FA
		// (set) Token: 0x06028C40 RID: 166976 RVA: 0x00599702 File Offset: 0x00597902
		public TGoalActDataUnion GoalAct { get; set; }

		// Token: 0x1700B2C3 RID: 45763
		// (get) Token: 0x06028C41 RID: 166977 RVA: 0x0059970B File Offset: 0x0059790B
		// (set) Token: 0x06028C42 RID: 166978 RVA: 0x00599713 File Offset: 0x00597913
		public EDiscardForEnergyAndActStrategy Strategy { get; set; }

		// Token: 0x06028C43 RID: 166979 RVA: 0x0059971C File Offset: 0x0059791C
		public IBvbAiDiscardForEnergyAndActDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.GoalAct = null;
			this.Strategy = EDiscardForEnergyAndActStrategy.Default;
		}
	}
}
