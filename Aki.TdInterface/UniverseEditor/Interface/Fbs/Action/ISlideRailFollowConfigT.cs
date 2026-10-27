using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714F RID: 29007
	public class ISlideRailFollowConfigT
	{
		// Token: 0x1700D780 RID: 55168
		// (get) Token: 0x060336C4 RID: 210628 RVA: 0x006EDD83 File Offset: 0x006EBF83
		// (set) Token: 0x060336C5 RID: 210629 RVA: 0x006EDD8B File Offset: 0x006EBF8B
		public int EntityId { get; set; }

		// Token: 0x1700D781 RID: 55169
		// (get) Token: 0x060336C6 RID: 210630 RVA: 0x006EDD94 File Offset: 0x006EBF94
		// (set) Token: 0x060336C7 RID: 210631 RVA: 0x006EDD9C File Offset: 0x006EBF9C
		public string FollowDaPath { get; set; }

		// Token: 0x060336C8 RID: 210632 RVA: 0x006EDDA5 File Offset: 0x006EBFA5
		public ISlideRailFollowConfigT()
		{
			this.EntityId = 0;
			this.FollowDaPath = null;
		}
	}
}
