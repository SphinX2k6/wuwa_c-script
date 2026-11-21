using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006360 RID: 25440
	public class IBvbAiDiscardForEnergyAndActDataT
	{
		// Token: 0x1700BC22 RID: 48162
		// (get) Token: 0x0602B2A7 RID: 176807 RVA: 0x005E2159 File Offset: 0x005E0359
		// (set) Token: 0x0602B2A8 RID: 176808 RVA: 0x005E2161 File Offset: 0x005E0361
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC23 RID: 48163
		// (get) Token: 0x0602B2A9 RID: 176809 RVA: 0x005E216A File Offset: 0x005E036A
		// (set) Token: 0x0602B2AA RID: 176810 RVA: 0x005E2172 File Offset: 0x005E0372
		public TGoalActDataUnion GoalAct { get; set; }

		// Token: 0x1700BC24 RID: 48164
		// (get) Token: 0x0602B2AB RID: 176811 RVA: 0x005E217B File Offset: 0x005E037B
		// (set) Token: 0x0602B2AC RID: 176812 RVA: 0x005E2183 File Offset: 0x005E0383
		public EDiscardForEnergyAndActStrategy Strategy { get; set; }

		// Token: 0x0602B2AD RID: 176813 RVA: 0x005E218C File Offset: 0x005E038C
		public IBvbAiDiscardForEnergyAndActDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.GoalAct = null;
			this.Strategy = EDiscardForEnergyAndActStrategy.Default;
		}
	}
}
