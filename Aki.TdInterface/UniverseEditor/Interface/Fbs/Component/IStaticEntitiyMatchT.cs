using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD0 RID: 24528
	public class IStaticEntitiyMatchT
	{
		// Token: 0x1700B5B1 RID: 46513
		// (get) Token: 0x0602949F RID: 169119 RVA: 0x005A2B09 File Offset: 0x005A0D09
		// (set) Token: 0x060294A0 RID: 169120 RVA: 0x005A2B11 File Offset: 0x005A0D11
		public IEntityCategoryT Category { get; set; }

		// Token: 0x1700B5B2 RID: 46514
		// (get) Token: 0x060294A1 RID: 169121 RVA: 0x005A2B1A File Offset: 0x005A0D1A
		// (set) Token: 0x060294A2 RID: 169122 RVA: 0x005A2B22 File Offset: 0x005A0D22
		public EEntityCategory CategoryType { get; set; }

		// Token: 0x1700B5B3 RID: 46515
		// (get) Token: 0x060294A3 RID: 169123 RVA: 0x005A2B2B File Offset: 0x005A0D2B
		// (set) Token: 0x060294A4 RID: 169124 RVA: 0x005A2B33 File Offset: 0x005A0D33
		public byte NullMask { get; set; }

		// Token: 0x060294A5 RID: 169125 RVA: 0x005A2B3C File Offset: 0x005A0D3C
		public IStaticEntitiyMatchT()
		{
			this.Category = null;
			this.CategoryType = EEntityCategory.MonsterMatchType;
			this.NullMask = 0;
		}
	}
}
