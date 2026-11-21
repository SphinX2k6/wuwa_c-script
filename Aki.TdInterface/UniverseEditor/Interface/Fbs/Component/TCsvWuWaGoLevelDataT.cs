using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006220 RID: 25120
	public class TCsvWuWaGoLevelDataT
	{
		// Token: 0x1700BB2B RID: 47915
		// (get) Token: 0x0602AC7D RID: 175229 RVA: 0x005D8068 File Offset: 0x005D6268
		// (set) Token: 0x0602AC7E RID: 175230 RVA: 0x005D8070 File Offset: 0x005D6270
		public string Key { get; set; }

		// Token: 0x1700BB2C RID: 47916
		// (get) Token: 0x0602AC7F RID: 175231 RVA: 0x005D8079 File Offset: 0x005D6279
		// (set) Token: 0x0602AC80 RID: 175232 RVA: 0x005D8081 File Offset: 0x005D6281
		public List<IWuWaGoGridDataT> GridDatas { get; set; }

		// Token: 0x1700BB2D RID: 47917
		// (get) Token: 0x0602AC81 RID: 175233 RVA: 0x005D808A File Offset: 0x005D628A
		// (set) Token: 0x0602AC82 RID: 175234 RVA: 0x005D8092 File Offset: 0x005D6292
		public List<IWuWaGoRoleInfoT> RoleList { get; set; }

		// Token: 0x0602AC83 RID: 175235 RVA: 0x005D809B File Offset: 0x005D629B
		public TCsvWuWaGoLevelDataT()
		{
			this.Key = null;
			this.GridDatas = null;
			this.RoleList = null;
		}
	}
}
