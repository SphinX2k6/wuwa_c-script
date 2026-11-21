using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005668 RID: 22120
	public class IDynamicTeleportComponentT
	{
		// Token: 0x17009F09 RID: 40713
		// (get) Token: 0x060235EE RID: 144878 RVA: 0x004DDC83 File Offset: 0x004DBE83
		// (set) Token: 0x060235EF RID: 144879 RVA: 0x004DDC8B File Offset: 0x004DBE8B
		public bool Disabled { get; set; }

		// Token: 0x17009F0A RID: 40714
		// (get) Token: 0x060235F0 RID: 144880 RVA: 0x004DDC94 File Offset: 0x004DBE94
		// (set) Token: 0x060235F1 RID: 144881 RVA: 0x004DDC9C File Offset: 0x004DBE9C
		public IPosAT Offset { get; set; }

		// Token: 0x17009F0B RID: 40715
		// (get) Token: 0x060235F2 RID: 144882 RVA: 0x004DDCA5 File Offset: 0x004DBEA5
		// (set) Token: 0x060235F3 RID: 144883 RVA: 0x004DDCAD File Offset: 0x004DBEAD
		public int PhantomSkillId { get; set; }

		// Token: 0x17009F0C RID: 40716
		// (get) Token: 0x060235F4 RID: 144884 RVA: 0x004DDCB6 File Offset: 0x004DBEB6
		// (set) Token: 0x060235F5 RID: 144885 RVA: 0x004DDCBE File Offset: 0x004DBEBE
		public byte NullMask { get; set; }

		// Token: 0x060235F6 RID: 144886 RVA: 0x004DDCC7 File Offset: 0x004DBEC7
		public IDynamicTeleportComponentT()
		{
			this.Disabled = false;
			this.Offset = null;
			this.PhantomSkillId = 0;
			this.NullMask = 0;
		}
	}
}
