using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061DB RID: 25051
	public class IWuWaGoLevelDataT
	{
		// Token: 0x1700BAC8 RID: 47816
		// (get) Token: 0x0602A9A5 RID: 174501 RVA: 0x005CF210 File Offset: 0x005CD410
		// (set) Token: 0x0602A9A6 RID: 174502 RVA: 0x005CF218 File Offset: 0x005CD418
		public string Key { get; set; }

		// Token: 0x1700BAC9 RID: 47817
		// (get) Token: 0x0602A9A7 RID: 174503 RVA: 0x005CF221 File Offset: 0x005CD421
		// (set) Token: 0x0602A9A8 RID: 174504 RVA: 0x005CF229 File Offset: 0x005CD429
		public List<IWuWaGoGridDataT> GridDatas { get; set; }

		// Token: 0x1700BACA RID: 47818
		// (get) Token: 0x0602A9A9 RID: 174505 RVA: 0x005CF232 File Offset: 0x005CD432
		// (set) Token: 0x0602A9AA RID: 174506 RVA: 0x005CF23A File Offset: 0x005CD43A
		public List<IWuWaGoRoleInfoT> RoleInfos { get; set; }

		// Token: 0x0602A9AB RID: 174507 RVA: 0x005CF243 File Offset: 0x005CD443
		public IWuWaGoLevelDataT()
		{
			this.Key = null;
			this.GridDatas = null;
			this.RoleInfos = null;
		}
	}
}
