using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C2F RID: 19503
	public class IGramophoneCheckConditionT
	{
		// Token: 0x17008DAD RID: 36269
		// (get) Token: 0x0601EE7F RID: 126591 RVA: 0x00453243 File Offset: 0x00451443
		// (set) Token: 0x0601EE80 RID: 126592 RVA: 0x0045324B File Offset: 0x0045144B
		public ECommonMatchType CheckType { get; set; }

		// Token: 0x17008DAE RID: 36270
		// (get) Token: 0x0601EE81 RID: 126593 RVA: 0x00453254 File Offset: 0x00451454
		// (set) Token: 0x0601EE82 RID: 126594 RVA: 0x0045325C File Offset: 0x0045145C
		public List<int> PlayList { get; set; }

		// Token: 0x0601EE83 RID: 126595 RVA: 0x00453265 File Offset: 0x00451465
		public IGramophoneCheckConditionT()
		{
			this.CheckType = ECommonMatchType.MatchAll;
			this.PlayList = null;
		}
	}
}
