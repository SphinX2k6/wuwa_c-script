using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A9 RID: 25001
	public class IWorldLevelBonusTypeT
	{
		// Token: 0x1700BA76 RID: 47734
		// (get) Token: 0x0602A7F7 RID: 174071 RVA: 0x005CBEFA File Offset: 0x005CA0FA
		// (set) Token: 0x0602A7F8 RID: 174072 RVA: 0x005CBF02 File Offset: 0x005CA102
		public EWorldLevelBonus Type { get; set; }

		// Token: 0x0602A7F9 RID: 174073 RVA: 0x005CBF0B File Offset: 0x005CA10B
		public IWorldLevelBonusTypeT()
		{
			this.Type = EWorldLevelBonus.WorldLevelTable;
		}
	}
}
