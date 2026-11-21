using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005542 RID: 21826
	public class IConditionActionT
	{
		// Token: 0x17009C0C RID: 39948
		// (get) Token: 0x06022A07 RID: 141831 RVA: 0x004C4F74 File Offset: 0x004C3174
		// (set) Token: 0x06022A08 RID: 141832 RVA: 0x004C4F7C File Offset: 0x004C317C
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009C0D RID: 39949
		// (get) Token: 0x06022A09 RID: 141833 RVA: 0x004C4F85 File Offset: 0x004C3185
		// (set) Token: 0x06022A0A RID: 141834 RVA: 0x004C4F8D File Offset: 0x004C318D
		public List<IActionInfoT> Action { get; set; }

		// Token: 0x06022A0B RID: 141835 RVA: 0x004C4F96 File Offset: 0x004C3196
		public IConditionActionT()
		{
			this.Condition = null;
			this.Action = null;
		}
	}
}
