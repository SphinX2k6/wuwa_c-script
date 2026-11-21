using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006860 RID: 26720
	public class IBattleStateMonsterLandingT
	{
		// Token: 0x1700C471 RID: 50289
		// (get) Token: 0x0602DAD0 RID: 187088 RVA: 0x0063F452 File Offset: 0x0063D652
		// (set) Token: 0x0602DAD1 RID: 187089 RVA: 0x0063F45A File Offset: 0x0063D65A
		public ESetBattleTagType Type { get; set; }

		// Token: 0x0602DAD2 RID: 187090 RVA: 0x0063F463 File Offset: 0x0063D663
		public IBattleStateMonsterLandingT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
