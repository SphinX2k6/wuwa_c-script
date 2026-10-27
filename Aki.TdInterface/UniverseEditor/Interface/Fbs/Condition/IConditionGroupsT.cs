using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BEA RID: 19434
	public class IConditionGroupsT
	{
		// Token: 0x17008D28 RID: 36136
		// (get) Token: 0x0601EC33 RID: 126003 RVA: 0x0044F543 File Offset: 0x0044D743
		// (set) Token: 0x0601EC34 RID: 126004 RVA: 0x0044F54B File Offset: 0x0044D74B
		public EConditionCount Type { get; set; }

		// Token: 0x17008D29 RID: 36137
		// (get) Token: 0x0601EC35 RID: 126005 RVA: 0x0044F554 File Offset: 0x0044D754
		// (set) Token: 0x0601EC36 RID: 126006 RVA: 0x0044F55C File Offset: 0x0044D75C
		public List<IConditionGroupT> Conditions { get; set; }

		// Token: 0x0601EC37 RID: 126007 RVA: 0x0044F565 File Offset: 0x0044D765
		public IConditionGroupsT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
