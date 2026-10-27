using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B39 RID: 23353
	public class IVisibleConditionGroupT
	{
		// Token: 0x1700B03E RID: 45118
		// (get) Token: 0x06027EA6 RID: 163494 RVA: 0x0057D1B1 File Offset: 0x0057B3B1
		// (set) Token: 0x06027EA7 RID: 163495 RVA: 0x0057D1B9 File Offset: 0x0057B3B9
		public List<TVisibleConditionUnion> Conditions { get; set; }

		// Token: 0x06027EA8 RID: 163496 RVA: 0x0057D1C2 File Offset: 0x0057B3C2
		public IVisibleConditionGroupT()
		{
			this.Conditions = null;
		}
	}
}
