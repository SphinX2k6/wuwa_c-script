using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F6D RID: 24429
	public class ISpawnMonsterPreDependOnPrecedingT
	{
		// Token: 0x1700B4F1 RID: 46321
		// (get) Token: 0x0602911B RID: 168219 RVA: 0x0059C02B File Offset: 0x0059A22B
		// (set) Token: 0x0602911C RID: 168220 RVA: 0x0059C033 File Offset: 0x0059A233
		public ESpawnMonsterPreCondition Type { get; set; }

		// Token: 0x1700B4F2 RID: 46322
		// (get) Token: 0x0602911D RID: 168221 RVA: 0x0059C03C File Offset: 0x0059A23C
		// (set) Token: 0x0602911E RID: 168222 RVA: 0x0059C044 File Offset: 0x0059A244
		public List<int> Ids { get; set; }

		// Token: 0x0602911F RID: 168223 RVA: 0x0059C04D File Offset: 0x0059A24D
		public ISpawnMonsterPreDependOnPrecedingT()
		{
			this.Type = ESpawnMonsterPreCondition.DependOnPreceding;
			this.Ids = null;
		}
	}
}
