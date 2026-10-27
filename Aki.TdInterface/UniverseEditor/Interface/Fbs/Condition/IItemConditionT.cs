using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C47 RID: 19527
	public class IItemConditionT
	{
		// Token: 0x17008DDF RID: 36319
		// (get) Token: 0x0601EF4D RID: 126797 RVA: 0x00454A3B File Offset: 0x00452C3B
		// (set) Token: 0x0601EF4E RID: 126798 RVA: 0x00454A43 File Offset: 0x00452C43
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008DE0 RID: 36320
		// (get) Token: 0x0601EF4F RID: 126799 RVA: 0x00454A4C File Offset: 0x00452C4C
		// (set) Token: 0x0601EF50 RID: 126800 RVA: 0x00454A54 File Offset: 0x00452C54
		public List<IItemConfigT> Items { get; set; }

		// Token: 0x0601EF51 RID: 126801 RVA: 0x00454A5D File Offset: 0x00452C5D
		public IItemConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Items = null;
		}
	}
}
