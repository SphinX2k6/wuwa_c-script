using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A0 RID: 21920
	public class IMonsterShowOnDeathEffectT
	{
		// Token: 0x1700A1E6 RID: 41446
		// (get) Token: 0x06024493 RID: 148627 RVA: 0x00502664 File Offset: 0x00500864
		// (set) Token: 0x06024494 RID: 148628 RVA: 0x0050266C File Offset: 0x0050086C
		public EMonsterShowOnDeathType Type { get; set; }

		// Token: 0x1700A1E7 RID: 41447
		// (get) Token: 0x06024495 RID: 148629 RVA: 0x00502675 File Offset: 0x00500875
		// (set) Token: 0x06024496 RID: 148630 RVA: 0x0050267D File Offset: 0x0050087D
		public int EffectId { get; set; }

		// Token: 0x06024497 RID: 148631 RVA: 0x00502686 File Offset: 0x00500886
		public IMonsterShowOnDeathEffectT()
		{
			this.Type = EMonsterShowOnDeathType.Effect;
			this.EffectId = 0;
		}
	}
}
