using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E7B RID: 20091
	public class IAiGearStrategyT
	{
		// Token: 0x17008FF3 RID: 36851
		// (get) Token: 0x0601F95E RID: 129374 RVA: 0x00466573 File Offset: 0x00464773
		// (set) Token: 0x0601F95F RID: 129375 RVA: 0x0046657B File Offset: 0x0046477B
		public EAiGearStrategy Type { get; set; }

		// Token: 0x17008FF4 RID: 36852
		// (get) Token: 0x0601F960 RID: 129376 RVA: 0x00466584 File Offset: 0x00464784
		// (set) Token: 0x0601F961 RID: 129377 RVA: 0x0046658C File Offset: 0x0046478C
		public IConditionGroupT Condition { get; set; }

		// Token: 0x0601F962 RID: 129378 RVA: 0x00466595 File Offset: 0x00464795
		public IAiGearStrategyT()
		{
			this.Type = EAiGearStrategy.RenjuStrategy;
			this.Condition = null;
		}
	}
}
