using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F36 RID: 16182
	public class IMonsterHpPointEntityConfigT
	{
		// Token: 0x1700708B RID: 28811
		// (get) Token: 0x06016FEB RID: 94187 RVA: 0x00351368 File Offset: 0x0034F568
		// (set) Token: 0x06016FEC RID: 94188 RVA: 0x00351370 File Offset: 0x0034F570
		public int EntityId { get; set; }

		// Token: 0x1700708C RID: 28812
		// (get) Token: 0x06016FED RID: 94189 RVA: 0x00351379 File Offset: 0x0034F579
		// (set) Token: 0x06016FEE RID: 94190 RVA: 0x00351381 File Offset: 0x0034F581
		public int PointOfEveryOnePercentHp { get; set; }

		// Token: 0x06016FEF RID: 94191 RVA: 0x0035138A File Offset: 0x0034F58A
		public IMonsterHpPointEntityConfigT()
		{
			this.EntityId = 0;
			this.PointOfEveryOnePercentHp = 0;
		}
	}
}
