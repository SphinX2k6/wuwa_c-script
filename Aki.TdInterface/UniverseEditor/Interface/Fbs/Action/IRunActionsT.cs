using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F10 RID: 28432
	public class IRunActionsT
	{
		// Token: 0x1700D362 RID: 54114
		// (get) Token: 0x060323BD RID: 205757 RVA: 0x006C9641 File Offset: 0x006C7841
		// (set) Token: 0x060323BE RID: 205758 RVA: 0x006C9649 File Offset: 0x006C7849
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x060323BF RID: 205759 RVA: 0x006C9652 File Offset: 0x006C7852
		public IRunActionsT()
		{
			this.ActionList = null;
		}
	}
}
