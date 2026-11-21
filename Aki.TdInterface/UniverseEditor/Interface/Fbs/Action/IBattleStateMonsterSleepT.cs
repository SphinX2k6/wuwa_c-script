using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006863 RID: 26723
	public class IBattleStateMonsterSleepT
	{
		// Token: 0x1700C474 RID: 50292
		// (get) Token: 0x0602DAE2 RID: 187106 RVA: 0x0063F5CA File Offset: 0x0063D7CA
		// (set) Token: 0x0602DAE3 RID: 187107 RVA: 0x0063F5D2 File Offset: 0x0063D7D2
		public ESetBattleTagType Type { get; set; }

		// Token: 0x0602DAE4 RID: 187108 RVA: 0x0063F5DB File Offset: 0x0063D7DB
		public IBattleStateMonsterSleepT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
