using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC6 RID: 19398
	public class IGlobalFixActionsT
	{
		// Token: 0x17008958 RID: 35160
		// (get) Token: 0x0601D9DE RID: 121310 RVA: 0x004285A1 File Offset: 0x004267A1
		// (set) Token: 0x0601D9DF RID: 121311 RVA: 0x004285A9 File Offset: 0x004267A9
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x0601D9E0 RID: 121312 RVA: 0x004285B2 File Offset: 0x004267B2
		public IGlobalFixActionsT()
		{
			this.ActionList = null;
		}
	}
}
