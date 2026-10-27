using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C5 RID: 25029
	public class IAvgPlayRoleActionT
	{
		// Token: 0x1700BA9B RID: 47771
		// (get) Token: 0x0602B21C RID: 176668 RVA: 0x005F23D1 File Offset: 0x005F05D1
		// (set) Token: 0x0602B21D RID: 176669 RVA: 0x005F23D9 File Offset: 0x005F05D9
		public List<IAvgPlayRoleActionItemT> RoleActionList { get; set; }

		// Token: 0x0602B21E RID: 176670 RVA: 0x005F23E2 File Offset: 0x005F05E2
		public IAvgPlayRoleActionT()
		{
			this.RoleActionList = null;
		}
	}
}
