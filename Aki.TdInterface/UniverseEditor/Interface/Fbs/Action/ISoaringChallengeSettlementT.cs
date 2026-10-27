using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007164 RID: 29028
	public class ISoaringChallengeSettlementT
	{
		// Token: 0x1700D7B0 RID: 55216
		// (get) Token: 0x0603377E RID: 210814 RVA: 0x006EF132 File Offset: 0x006ED332
		// (set) Token: 0x0603377F RID: 210815 RVA: 0x006EF13A File Offset: 0x006ED33A
		public EDynamicSettlementType Type { get; set; }

		// Token: 0x06033780 RID: 210816 RVA: 0x006EF143 File Offset: 0x006ED343
		public ISoaringChallengeSettlementT()
		{
			this.Type = EDynamicSettlementType.Battle;
		}
	}
}
