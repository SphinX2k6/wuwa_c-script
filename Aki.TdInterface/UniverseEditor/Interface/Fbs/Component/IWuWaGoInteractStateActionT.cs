using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBF RID: 23487
	public class IWuWaGoInteractStateActionT
	{
		// Token: 0x1700B173 RID: 45427
		// (get) Token: 0x06028397 RID: 164759 RVA: 0x00586DC0 File Offset: 0x00584FC0
		// (set) Token: 0x06028398 RID: 164760 RVA: 0x00586DC8 File Offset: 0x00584FC8
		public string EntityState { get; set; }

		// Token: 0x1700B174 RID: 45428
		// (get) Token: 0x06028399 RID: 164761 RVA: 0x00586DD1 File Offset: 0x00584FD1
		// (set) Token: 0x0602839A RID: 164762 RVA: 0x00586DD9 File Offset: 0x00584FD9
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x0602839B RID: 164763 RVA: 0x00586DE2 File Offset: 0x00584FE2
		public IWuWaGoInteractStateActionT()
		{
			this.EntityState = null;
			this.ActionList = null;
		}
	}
}
