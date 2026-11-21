using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D8C RID: 23948
	public class IProbabilityRefreshItemT
	{
		// Token: 0x1700B043 RID: 45123
		// (get) Token: 0x06027E1F RID: 163359 RVA: 0x005748E9 File Offset: 0x00572AE9
		// (set) Token: 0x06027E20 RID: 163360 RVA: 0x005748F1 File Offset: 0x00572AF1
		public int Probability { get; set; }

		// Token: 0x1700B044 RID: 45124
		// (get) Token: 0x06027E21 RID: 163361 RVA: 0x005748FA File Offset: 0x00572AFA
		// (set) Token: 0x06027E22 RID: 163362 RVA: 0x00574902 File Offset: 0x00572B02
		public int RefreshEntityId { get; set; }

		// Token: 0x1700B045 RID: 45125
		// (get) Token: 0x06027E23 RID: 163363 RVA: 0x0057490B File Offset: 0x00572B0B
		// (set) Token: 0x06027E24 RID: 163364 RVA: 0x00574913 File Offset: 0x00572B13
		public IConditionGroupT AdditionalCondition { get; set; }

		// Token: 0x06027E25 RID: 163365 RVA: 0x0057491C File Offset: 0x00572B1C
		public IProbabilityRefreshItemT()
		{
			this.Probability = 0;
			this.RefreshEntityId = 0;
			this.AdditionalCondition = null;
		}
	}
}
