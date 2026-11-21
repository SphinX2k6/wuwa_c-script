using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538C RID: 21388
	public class IAiGearStrategyT
	{
		// Token: 0x1700972C RID: 38700
		// (get) Token: 0x060215A9 RID: 136617 RVA: 0x0049A58B File Offset: 0x0049878B
		// (set) Token: 0x060215AA RID: 136618 RVA: 0x0049A593 File Offset: 0x00498793
		public EAiGearStrategy Type { get; set; }

		// Token: 0x1700972D RID: 38701
		// (get) Token: 0x060215AB RID: 136619 RVA: 0x0049A59C File Offset: 0x0049879C
		// (set) Token: 0x060215AC RID: 136620 RVA: 0x0049A5A4 File Offset: 0x004987A4
		public IConditionGroupT Condition { get; set; }

		// Token: 0x060215AD RID: 136621 RVA: 0x0049A5AD File Offset: 0x004987AD
		public IAiGearStrategyT()
		{
			this.Type = EAiGearStrategy.RenjuStrategy;
			this.Condition = null;
		}
	}
}
