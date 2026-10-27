using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F2 RID: 25074
	public class IBattleStateMonsterLandingT
	{
		// Token: 0x1700BAEE RID: 47854
		// (get) Token: 0x0602B389 RID: 177033 RVA: 0x005F49DE File Offset: 0x005F2BDE
		// (set) Token: 0x0602B38A RID: 177034 RVA: 0x005F49E6 File Offset: 0x005F2BE6
		public ESetBattleTagType Type { get; set; }

		// Token: 0x0602B38B RID: 177035 RVA: 0x005F49EF File Offset: 0x005F2BEF
		public IBattleStateMonsterLandingT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
