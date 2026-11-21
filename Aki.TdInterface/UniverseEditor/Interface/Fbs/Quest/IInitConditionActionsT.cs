using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F3 RID: 17139
	public class IInitConditionActionsT
	{
		// Token: 0x17007558 RID: 30040
		// (get) Token: 0x06018118 RID: 98584 RVA: 0x0036F178 File Offset: 0x0036D378
		// (set) Token: 0x06018119 RID: 98585 RVA: 0x0036F180 File Offset: 0x0036D380
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007559 RID: 30041
		// (get) Token: 0x0601811A RID: 98586 RVA: 0x0036F189 File Offset: 0x0036D389
		// (set) Token: 0x0601811B RID: 98587 RVA: 0x0036F191 File Offset: 0x0036D391
		public List<IActionInfoT> Action { get; set; }

		// Token: 0x0601811C RID: 98588 RVA: 0x0036F19A File Offset: 0x0036D39A
		public IInitConditionActionsT()
		{
			this.Condition = null;
			this.Action = null;
		}
	}
}
