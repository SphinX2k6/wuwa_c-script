using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B87 RID: 23431
	public class IWindSourceComponentT
	{
		// Token: 0x1700B112 RID: 45330
		// (get) Token: 0x060281C7 RID: 164295 RVA: 0x005836C9 File Offset: 0x005818C9
		// (set) Token: 0x060281C8 RID: 164296 RVA: 0x005836D1 File Offset: 0x005818D1
		public bool Disabled { get; set; }

		// Token: 0x1700B113 RID: 45331
		// (get) Token: 0x060281C9 RID: 164297 RVA: 0x005836DA File Offset: 0x005818DA
		// (set) Token: 0x060281CA RID: 164298 RVA: 0x005836E2 File Offset: 0x005818E2
		public IWindDirectionalT WindSource { get; set; }

		// Token: 0x1700B114 RID: 45332
		// (get) Token: 0x060281CB RID: 164299 RVA: 0x005836EB File Offset: 0x005818EB
		// (set) Token: 0x060281CC RID: 164300 RVA: 0x005836F3 File Offset: 0x005818F3
		public byte NullMask { get; set; }

		// Token: 0x060281CD RID: 164301 RVA: 0x005836FC File Offset: 0x005818FC
		public IWindSourceComponentT()
		{
			this.Disabled = false;
			this.WindSource = null;
			this.NullMask = 0;
		}
	}
}
