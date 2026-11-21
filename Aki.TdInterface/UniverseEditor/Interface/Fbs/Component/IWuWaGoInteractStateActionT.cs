using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D5 RID: 25045
	public class IWuWaGoInteractStateActionT
	{
		// Token: 0x1700BABB RID: 47803
		// (get) Token: 0x0602A95B RID: 174427 RVA: 0x005CE850 File Offset: 0x005CCA50
		// (set) Token: 0x0602A95C RID: 174428 RVA: 0x005CE858 File Offset: 0x005CCA58
		public string EntityState { get; set; }

		// Token: 0x1700BABC RID: 47804
		// (get) Token: 0x0602A95D RID: 174429 RVA: 0x005CE861 File Offset: 0x005CCA61
		// (set) Token: 0x0602A95E RID: 174430 RVA: 0x005CE869 File Offset: 0x005CCA69
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x0602A95F RID: 174431 RVA: 0x005CE872 File Offset: 0x005CCA72
		public IWuWaGoInteractStateActionT()
		{
			this.EntityState = null;
			this.ActionList = null;
		}
	}
}
