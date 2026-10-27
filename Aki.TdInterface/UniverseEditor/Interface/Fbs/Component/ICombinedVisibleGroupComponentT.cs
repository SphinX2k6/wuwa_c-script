using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC8 RID: 20424
	public class ICombinedVisibleGroupComponentT
	{
		// Token: 0x170093ED RID: 37869
		// (get) Token: 0x06020859 RID: 133209 RVA: 0x00485EDE File Offset: 0x004840DE
		// (set) Token: 0x0602085A RID: 133210 RVA: 0x00485EE6 File Offset: 0x004840E6
		public bool Disabled { get; set; }

		// Token: 0x170093EE RID: 37870
		// (get) Token: 0x0602085B RID: 133211 RVA: 0x00485EEF File Offset: 0x004840EF
		// (set) Token: 0x0602085C RID: 133212 RVA: 0x00485EF7 File Offset: 0x004840F7
		public List<int> AreaIds { get; set; }

		// Token: 0x170093EF RID: 37871
		// (get) Token: 0x0602085D RID: 133213 RVA: 0x00485F00 File Offset: 0x00484100
		// (set) Token: 0x0602085E RID: 133214 RVA: 0x00485F08 File Offset: 0x00484108
		public bool IncludeSubArea { get; set; }

		// Token: 0x170093F0 RID: 37872
		// (get) Token: 0x0602085F RID: 133215 RVA: 0x00485F11 File Offset: 0x00484111
		// (set) Token: 0x06020860 RID: 133216 RVA: 0x00485F19 File Offset: 0x00484119
		public List<int> EntityIds { get; set; }

		// Token: 0x170093F1 RID: 37873
		// (get) Token: 0x06020861 RID: 133217 RVA: 0x00485F22 File Offset: 0x00484122
		// (set) Token: 0x06020862 RID: 133218 RVA: 0x00485F2A File Offset: 0x0048412A
		public byte NullMask { get; set; }

		// Token: 0x06020863 RID: 133219 RVA: 0x00485F33 File Offset: 0x00484133
		public ICombinedVisibleGroupComponentT()
		{
			this.Disabled = false;
			this.AreaIds = null;
			this.IncludeSubArea = false;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
