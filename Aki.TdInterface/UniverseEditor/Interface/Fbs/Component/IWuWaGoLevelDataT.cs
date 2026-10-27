using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC5 RID: 23493
	public class IWuWaGoLevelDataT
	{
		// Token: 0x1700B180 RID: 45440
		// (get) Token: 0x060283E1 RID: 164833 RVA: 0x00587780 File Offset: 0x00585980
		// (set) Token: 0x060283E2 RID: 164834 RVA: 0x00587788 File Offset: 0x00585988
		public string Key { get; set; }

		// Token: 0x1700B181 RID: 45441
		// (get) Token: 0x060283E3 RID: 164835 RVA: 0x00587791 File Offset: 0x00585991
		// (set) Token: 0x060283E4 RID: 164836 RVA: 0x00587799 File Offset: 0x00585999
		public List<IWuWaGoGridDataT> GridDatas { get; set; }

		// Token: 0x1700B182 RID: 45442
		// (get) Token: 0x060283E5 RID: 164837 RVA: 0x005877A2 File Offset: 0x005859A2
		// (set) Token: 0x060283E6 RID: 164838 RVA: 0x005877AA File Offset: 0x005859AA
		public List<IWuWaGoRoleInfoT> RoleInfos { get; set; }

		// Token: 0x060283E7 RID: 164839 RVA: 0x005877B3 File Offset: 0x005859B3
		public IWuWaGoLevelDataT()
		{
			this.Key = null;
			this.GridDatas = null;
			this.RoleInfos = null;
		}
	}
}
