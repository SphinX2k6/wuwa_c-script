using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061EF RID: 25071
	public class IBattleStateFinalMonsterLandingT
	{
		// Token: 0x1700BAEB RID: 47851
		// (get) Token: 0x0602B377 RID: 177015 RVA: 0x005F4866 File Offset: 0x005F2A66
		// (set) Token: 0x0602B378 RID: 177016 RVA: 0x005F486E File Offset: 0x005F2A6E
		public ESetBattleTagType Type { get; set; }

		// Token: 0x0602B379 RID: 177017 RVA: 0x005F4877 File Offset: 0x005F2A77
		public IBattleStateFinalMonsterLandingT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
