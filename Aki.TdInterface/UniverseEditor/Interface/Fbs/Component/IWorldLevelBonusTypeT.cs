using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B93 RID: 23443
	public class IWorldLevelBonusTypeT
	{
		// Token: 0x1700B12E RID: 45358
		// (get) Token: 0x06028233 RID: 164403 RVA: 0x0058446A File Offset: 0x0058266A
		// (set) Token: 0x06028234 RID: 164404 RVA: 0x00584472 File Offset: 0x00582672
		public EWorldLevelBonus Type { get; set; }

		// Token: 0x06028235 RID: 164405 RVA: 0x0058447B File Offset: 0x0058267B
		public IWorldLevelBonusTypeT()
		{
			this.Type = EWorldLevelBonus.WorldLevelTable;
		}
	}
}
