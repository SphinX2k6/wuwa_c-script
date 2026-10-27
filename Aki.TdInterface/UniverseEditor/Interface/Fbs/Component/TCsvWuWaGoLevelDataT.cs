using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C01 RID: 23553
	public class TCsvWuWaGoLevelDataT
	{
		// Token: 0x1700B1DD RID: 45533
		// (get) Token: 0x0602868D RID: 165517 RVA: 0x00590120 File Offset: 0x0058E320
		// (set) Token: 0x0602868E RID: 165518 RVA: 0x00590128 File Offset: 0x0058E328
		public string Key { get; set; }

		// Token: 0x1700B1DE RID: 45534
		// (get) Token: 0x0602868F RID: 165519 RVA: 0x00590131 File Offset: 0x0058E331
		// (set) Token: 0x06028690 RID: 165520 RVA: 0x00590139 File Offset: 0x0058E339
		public List<IWuWaGoGridDataT> GridDatas { get; set; }

		// Token: 0x1700B1DF RID: 45535
		// (get) Token: 0x06028691 RID: 165521 RVA: 0x00590142 File Offset: 0x0058E342
		// (set) Token: 0x06028692 RID: 165522 RVA: 0x0059014A File Offset: 0x0058E34A
		public List<IWuWaGoRoleInfoT> RoleList { get; set; }

		// Token: 0x06028693 RID: 165523 RVA: 0x00590153 File Offset: 0x0058E353
		public TCsvWuWaGoLevelDataT()
		{
			this.Key = null;
			this.GridDatas = null;
			this.RoleList = null;
		}
	}
}
