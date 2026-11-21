using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005107 RID: 20743
	public class IEntityStateConditionT
	{
		// Token: 0x170094AD RID: 38061
		// (get) Token: 0x060209BD RID: 133565 RVA: 0x0048584F File Offset: 0x00483A4F
		// (set) Token: 0x060209BE RID: 133566 RVA: 0x00485857 File Offset: 0x00483A57
		public int EntityId { get; set; }

		// Token: 0x170094AE RID: 38062
		// (get) Token: 0x060209BF RID: 133567 RVA: 0x00485860 File Offset: 0x00483A60
		// (set) Token: 0x060209C0 RID: 133568 RVA: 0x00485868 File Offset: 0x00483A68
		public string State { get; set; }

		// Token: 0x060209C1 RID: 133569 RVA: 0x00485871 File Offset: 0x00483A71
		public IEntityStateConditionT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
