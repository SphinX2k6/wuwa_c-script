using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E31 RID: 24113
	public class IRefreshGroupComponentT
	{
		// Token: 0x1700B1BF RID: 45503
		// (get) Token: 0x06028485 RID: 164997 RVA: 0x005821A8 File Offset: 0x005803A8
		// (set) Token: 0x06028486 RID: 164998 RVA: 0x005821B0 File Offset: 0x005803B0
		public bool Disabled { get; set; }

		// Token: 0x1700B1C0 RID: 45504
		// (get) Token: 0x06028487 RID: 164999 RVA: 0x005821B9 File Offset: 0x005803B9
		// (set) Token: 0x06028488 RID: 165000 RVA: 0x005821C1 File Offset: 0x005803C1
		public List<int> EntityIds { get; set; }

		// Token: 0x1700B1C1 RID: 45505
		// (get) Token: 0x06028489 RID: 165001 RVA: 0x005821CA File Offset: 0x005803CA
		// (set) Token: 0x0602848A RID: 165002 RVA: 0x005821D2 File Offset: 0x005803D2
		public TRefreshContentUnion RefreshContent { get; set; }

		// Token: 0x1700B1C2 RID: 45506
		// (get) Token: 0x0602848B RID: 165003 RVA: 0x005821DB File Offset: 0x005803DB
		// (set) Token: 0x0602848C RID: 165004 RVA: 0x005821E3 File Offset: 0x005803E3
		public TRefreshRuleUnion RefreshRule { get; set; }

		// Token: 0x1700B1C3 RID: 45507
		// (get) Token: 0x0602848D RID: 165005 RVA: 0x005821EC File Offset: 0x005803EC
		// (set) Token: 0x0602848E RID: 165006 RVA: 0x005821F4 File Offset: 0x005803F4
		public IStateChangeConfigT StateChangeConfig { get; set; }

		// Token: 0x1700B1C4 RID: 45508
		// (get) Token: 0x0602848F RID: 165007 RVA: 0x005821FD File Offset: 0x005803FD
		// (set) Token: 0x06028490 RID: 165008 RVA: 0x00582205 File Offset: 0x00580405
		public byte NullMask { get; set; }

		// Token: 0x06028491 RID: 165009 RVA: 0x0058220E File Offset: 0x0058040E
		public IRefreshGroupComponentT()
		{
			this.Disabled = false;
			this.EntityIds = null;
			this.RefreshContent = null;
			this.RefreshRule = null;
			this.StateChangeConfig = null;
			this.NullMask = 0;
		}
	}
}
