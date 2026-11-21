using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007697 RID: 30359
	public class IRunActionsT
	{
		// Token: 0x1700DEBE RID: 57022
		// (get) Token: 0x06035415 RID: 218133 RVA: 0x007255A9 File Offset: 0x007237A9
		// (set) Token: 0x06035416 RID: 218134 RVA: 0x007255B1 File Offset: 0x007237B1
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x06035417 RID: 218135 RVA: 0x007255BA File Offset: 0x007237BA
		public IRunActionsT()
		{
			this.ActionList = null;
		}
	}
}
