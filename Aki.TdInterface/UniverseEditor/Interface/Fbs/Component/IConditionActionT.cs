using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE3 RID: 20451
	public class IConditionActionT
	{
		// Token: 0x1700942B RID: 37931
		// (get) Token: 0x06020AE7 RID: 133863 RVA: 0x0048B524 File Offset: 0x00489724
		// (set) Token: 0x06020AE8 RID: 133864 RVA: 0x0048B52C File Offset: 0x0048972C
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700942C RID: 37932
		// (get) Token: 0x06020AE9 RID: 133865 RVA: 0x0048B535 File Offset: 0x00489735
		// (set) Token: 0x06020AEA RID: 133866 RVA: 0x0048B53D File Offset: 0x0048973D
		public List<IActionInfoT> Action { get; set; }

		// Token: 0x06020AEB RID: 133867 RVA: 0x0048B546 File Offset: 0x00489746
		public IConditionActionT()
		{
			this.Condition = null;
			this.Action = null;
		}
	}
}
