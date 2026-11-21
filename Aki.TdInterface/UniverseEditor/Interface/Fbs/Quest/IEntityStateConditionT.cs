using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424B RID: 16971
	public class IEntityStateConditionT
	{
		// Token: 0x170073B9 RID: 29625
		// (get) Token: 0x060179F9 RID: 96761 RVA: 0x0035E8BB File Offset: 0x0035CABB
		// (set) Token: 0x060179FA RID: 96762 RVA: 0x0035E8C3 File Offset: 0x0035CAC3
		public int EntityId { get; set; }

		// Token: 0x170073BA RID: 29626
		// (get) Token: 0x060179FB RID: 96763 RVA: 0x0035E8CC File Offset: 0x0035CACC
		// (set) Token: 0x060179FC RID: 96764 RVA: 0x0035E8D4 File Offset: 0x0035CAD4
		public string State { get; set; }

		// Token: 0x060179FD RID: 96765 RVA: 0x0035E8DD File Offset: 0x0035CADD
		public IEntityStateConditionT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
