using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3E RID: 23358
	public class IMonsterShowOnDeathEffectT
	{
		// Token: 0x1700AA6E RID: 43630
		// (get) Token: 0x060266A0 RID: 157344 RVA: 0x00542BDC File Offset: 0x00540DDC
		// (set) Token: 0x060266A1 RID: 157345 RVA: 0x00542BE4 File Offset: 0x00540DE4
		public EMonsterShowOnDeathType Type { get; set; }

		// Token: 0x1700AA6F RID: 43631
		// (get) Token: 0x060266A2 RID: 157346 RVA: 0x00542BED File Offset: 0x00540DED
		// (set) Token: 0x060266A3 RID: 157347 RVA: 0x00542BF5 File Offset: 0x00540DF5
		public int EffectId { get; set; }

		// Token: 0x060266A4 RID: 157348 RVA: 0x00542BFE File Offset: 0x00540DFE
		public IMonsterShowOnDeathEffectT()
		{
			this.Type = EMonsterShowOnDeathType.Effect;
			this.EffectId = 0;
		}
	}
}
