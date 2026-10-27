using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F3F RID: 16191
	public class IMonsterPointEntityConfigT
	{
		// Token: 0x1700709A RID: 28826
		// (get) Token: 0x06017035 RID: 94261 RVA: 0x00351A94 File Offset: 0x0034FC94
		// (set) Token: 0x06017036 RID: 94262 RVA: 0x00351A9C File Offset: 0x0034FC9C
		public int EntityId { get; set; }

		// Token: 0x1700709B RID: 28827
		// (get) Token: 0x06017037 RID: 94263 RVA: 0x00351AA5 File Offset: 0x0034FCA5
		// (set) Token: 0x06017038 RID: 94264 RVA: 0x00351AAD File Offset: 0x0034FCAD
		public int Point { get; set; }

		// Token: 0x06017039 RID: 94265 RVA: 0x00351AB6 File Offset: 0x0034FCB6
		public IMonsterPointEntityConfigT()
		{
			this.EntityId = 0;
			this.Point = 0;
		}
	}
}
