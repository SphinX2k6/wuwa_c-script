using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB0 RID: 23472
	public class INoRenderPortalModeT
	{
		// Token: 0x1700AB97 RID: 43927
		// (get) Token: 0x06026B31 RID: 158513 RVA: 0x0054C38C File Offset: 0x0054A58C
		// (set) Token: 0x06026B32 RID: 158514 RVA: 0x0054C394 File Offset: 0x0054A594
		public ENoRenderPortalType Type { get; set; }

		// Token: 0x1700AB98 RID: 43928
		// (get) Token: 0x06026B33 RID: 158515 RVA: 0x0054C39D File Offset: 0x0054A59D
		// (set) Token: 0x06026B34 RID: 158516 RVA: 0x0054C3A5 File Offset: 0x0054A5A5
		public EPortalModel PortalModel { get; set; }

		// Token: 0x06026B35 RID: 158517 RVA: 0x0054C3AE File Offset: 0x0054A5AE
		public INoRenderPortalModeT()
		{
			this.Type = ENoRenderPortalType.Static;
			this.PortalModel = EPortalModel.A;
		}
	}
}
