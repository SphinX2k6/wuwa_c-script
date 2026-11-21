using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200513A RID: 20794
	public class IItemConditionT
	{
		// Token: 0x17009508 RID: 38152
		// (get) Token: 0x06020B51 RID: 133969 RVA: 0x00488317 File Offset: 0x00486517
		// (set) Token: 0x06020B52 RID: 133970 RVA: 0x0048831F File Offset: 0x0048651F
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009509 RID: 38153
		// (get) Token: 0x06020B53 RID: 133971 RVA: 0x00488328 File Offset: 0x00486528
		// (set) Token: 0x06020B54 RID: 133972 RVA: 0x00488330 File Offset: 0x00486530
		public List<IItemConfigT> Items { get; set; }

		// Token: 0x06020B55 RID: 133973 RVA: 0x00488339 File Offset: 0x00486539
		public IItemConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Items = null;
		}
	}
}
