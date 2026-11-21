using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C63 RID: 31843
	public class ITriggerActionsT
	{
		// Token: 0x1700EE59 RID: 61017
		// (get) Token: 0x06039663 RID: 235107 RVA: 0x007BFB05 File Offset: 0x007BDD05
		// (set) Token: 0x06039664 RID: 235108 RVA: 0x007BFB0D File Offset: 0x007BDD0D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06039665 RID: 235109 RVA: 0x007BFB16 File Offset: 0x007BDD16
		public ITriggerActionsT()
		{
			this.Actions = null;
		}
	}
}
