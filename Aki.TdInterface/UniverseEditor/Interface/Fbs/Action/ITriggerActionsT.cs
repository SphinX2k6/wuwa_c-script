using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007470 RID: 29808
	public class ITriggerActionsT
	{
		// Token: 0x1700E23C RID: 57916
		// (get) Token: 0x0603627A RID: 221818 RVA: 0x0075CDD9 File Offset: 0x0075AFD9
		// (set) Token: 0x0603627B RID: 221819 RVA: 0x0075CDE1 File Offset: 0x0075AFE1
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x0603627C RID: 221820 RVA: 0x0075CDEA File Offset: 0x0075AFEA
		public ITriggerActionsT()
		{
			this.Actions = null;
		}
	}
}
