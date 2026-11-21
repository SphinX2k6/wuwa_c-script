using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006833 RID: 26675
	public class IAvgPlayRoleActionT
	{
		// Token: 0x1700C41E RID: 50206
		// (get) Token: 0x0602D963 RID: 186723 RVA: 0x0063CE45 File Offset: 0x0063B045
		// (set) Token: 0x0602D964 RID: 186724 RVA: 0x0063CE4D File Offset: 0x0063B04D
		public List<IAvgPlayRoleActionItemT> RoleActionList { get; set; }

		// Token: 0x0602D965 RID: 186725 RVA: 0x0063CE56 File Offset: 0x0063B056
		public IAvgPlayRoleActionT()
		{
			this.RoleActionList = null;
		}
	}
}
