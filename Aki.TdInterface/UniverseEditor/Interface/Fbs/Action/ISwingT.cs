using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007248 RID: 29256
	public class ISwingT
	{
		// Token: 0x1700D915 RID: 55573
		// (get) Token: 0x06033E44 RID: 212548 RVA: 0x006FB0A1 File Offset: 0x006F92A1
		// (set) Token: 0x06033E45 RID: 212549 RVA: 0x006FB0A9 File Offset: 0x006F92A9
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D916 RID: 55574
		// (get) Token: 0x06033E46 RID: 212550 RVA: 0x006FB0B2 File Offset: 0x006F92B2
		// (set) Token: 0x06033E47 RID: 212551 RVA: 0x006FB0BA File Offset: 0x006F92BA
		public string SwingDa { get; set; }

		// Token: 0x1700D917 RID: 55575
		// (get) Token: 0x06033E48 RID: 212552 RVA: 0x006FB0C3 File Offset: 0x006F92C3
		// (set) Token: 0x06033E49 RID: 212553 RVA: 0x006FB0CB File Offset: 0x006F92CB
		public int EntityId { get; set; }

		// Token: 0x06033E4A RID: 212554 RVA: 0x006FB0D4 File Offset: 0x006F92D4
		public ISwingT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.SwingDa = null;
			this.EntityId = 0;
		}
	}
}
