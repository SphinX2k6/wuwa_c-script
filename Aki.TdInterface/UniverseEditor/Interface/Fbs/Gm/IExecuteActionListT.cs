using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AAE RID: 19118
	public class IExecuteActionListT
	{
		// Token: 0x170085E5 RID: 34277
		// (get) Token: 0x0601CBDE RID: 117726 RVA: 0x0040CFDF File Offset: 0x0040B1DF
		// (set) Token: 0x0601CBDF RID: 117727 RVA: 0x0040CFE7 File Offset: 0x0040B1E7
		public EGmCommand Type { get; set; }

		// Token: 0x170085E6 RID: 34278
		// (get) Token: 0x0601CBE0 RID: 117728 RVA: 0x0040CFF0 File Offset: 0x0040B1F0
		// (set) Token: 0x0601CBE1 RID: 117729 RVA: 0x0040CFF8 File Offset: 0x0040B1F8
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x0601CBE2 RID: 117730 RVA: 0x0040D001 File Offset: 0x0040B201
		public IExecuteActionListT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.ActionList = null;
		}
	}
}
