using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E43 RID: 24131
	public class IRefreshSingleComponentT
	{
		// Token: 0x1700B1DF RID: 45535
		// (get) Token: 0x0602850F RID: 165135 RVA: 0x00582FC1 File Offset: 0x005811C1
		// (set) Token: 0x06028510 RID: 165136 RVA: 0x00582FC9 File Offset: 0x005811C9
		public bool Disabled { get; set; }

		// Token: 0x1700B1E0 RID: 45536
		// (get) Token: 0x06028511 RID: 165137 RVA: 0x00582FD2 File Offset: 0x005811D2
		// (set) Token: 0x06028512 RID: 165138 RVA: 0x00582FDA File Offset: 0x005811DA
		public int RefreshInterval { get; set; }

		// Token: 0x1700B1E1 RID: 45537
		// (get) Token: 0x06028513 RID: 165139 RVA: 0x00582FE3 File Offset: 0x005811E3
		// (set) Token: 0x06028514 RID: 165140 RVA: 0x00582FEB File Offset: 0x005811EB
		public bool DelayRefresh { get; set; }

		// Token: 0x1700B1E2 RID: 45538
		// (get) Token: 0x06028515 RID: 165141 RVA: 0x00582FF4 File Offset: 0x005811F4
		// (set) Token: 0x06028516 RID: 165142 RVA: 0x00582FFC File Offset: 0x005811FC
		public string TemplateGuid { get; set; }

		// Token: 0x1700B1E3 RID: 45539
		// (get) Token: 0x06028517 RID: 165143 RVA: 0x00583005 File Offset: 0x00581205
		// (set) Token: 0x06028518 RID: 165144 RVA: 0x0058300D File Offset: 0x0058120D
		public byte NullMask { get; set; }

		// Token: 0x06028519 RID: 165145 RVA: 0x00583016 File Offset: 0x00581216
		public IRefreshSingleComponentT()
		{
			this.Disabled = false;
			this.RefreshInterval = 0;
			this.DelayRefresh = false;
			this.TemplateGuid = null;
			this.NullMask = 0;
		}
	}
}
