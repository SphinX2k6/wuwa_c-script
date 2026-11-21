using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005353 RID: 21331
	public class IActionByConditionT
	{
		// Token: 0x17009699 RID: 38553
		// (get) Token: 0x06021345 RID: 136005 RVA: 0x004951D4 File Offset: 0x004933D4
		// (set) Token: 0x06021346 RID: 136006 RVA: 0x004951DC File Offset: 0x004933DC
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700969A RID: 38554
		// (get) Token: 0x06021347 RID: 136007 RVA: 0x004951E5 File Offset: 0x004933E5
		// (set) Token: 0x06021348 RID: 136008 RVA: 0x004951ED File Offset: 0x004933ED
		public List<IActionInfoT> ActiveActions { get; set; }

		// Token: 0x06021349 RID: 136009 RVA: 0x004951F6 File Offset: 0x004933F6
		public IActionByConditionT()
		{
			this.Condition = null;
			this.ActiveActions = null;
		}
	}
}
