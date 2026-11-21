using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200614F RID: 24911
	public class IVisibleConditionGroupT
	{
		// Token: 0x1700B986 RID: 47494
		// (get) Token: 0x0602A46A RID: 173162 RVA: 0x005C4C41 File Offset: 0x005C2E41
		// (set) Token: 0x0602A46B RID: 173163 RVA: 0x005C4C49 File Offset: 0x005C2E49
		public List<TVisibleConditionUnion> Conditions { get; set; }

		// Token: 0x0602A46C RID: 173164 RVA: 0x005C4C52 File Offset: 0x005C2E52
		public IVisibleConditionGroupT()
		{
			this.Conditions = null;
		}
	}
}
