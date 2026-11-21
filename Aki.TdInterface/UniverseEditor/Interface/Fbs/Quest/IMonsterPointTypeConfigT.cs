using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004380 RID: 17280
	public class IMonsterPointTypeConfigT
	{
		// Token: 0x17007690 RID: 30352
		// (get) Token: 0x060186AD RID: 100013 RVA: 0x0037B108 File Offset: 0x00379308
		// (set) Token: 0x060186AE RID: 100014 RVA: 0x0037B110 File Offset: 0x00379310
		public EMonsterMatchType MonsterType { get; set; }

		// Token: 0x17007691 RID: 30353
		// (get) Token: 0x060186AF RID: 100015 RVA: 0x0037B119 File Offset: 0x00379319
		// (set) Token: 0x060186B0 RID: 100016 RVA: 0x0037B121 File Offset: 0x00379321
		public int Point { get; set; }

		// Token: 0x060186B1 RID: 100017 RVA: 0x0037B12A File Offset: 0x0037932A
		public IMonsterPointTypeConfigT()
		{
			this.MonsterType = EMonsterMatchType.Normal;
			this.Point = 0;
		}
	}
}
