using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F5 RID: 25077
	public class IBattleStateMonsterSleepT
	{
		// Token: 0x1700BAF1 RID: 47857
		// (get) Token: 0x0602B39B RID: 177051 RVA: 0x005F4B56 File Offset: 0x005F2D56
		// (set) Token: 0x0602B39C RID: 177052 RVA: 0x005F4B5E File Offset: 0x005F2D5E
		public ESetBattleTagType Type { get; set; }

		// Token: 0x0602B39D RID: 177053 RVA: 0x005F4B67 File Offset: 0x005F2D67
		public IBattleStateMonsterSleepT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
