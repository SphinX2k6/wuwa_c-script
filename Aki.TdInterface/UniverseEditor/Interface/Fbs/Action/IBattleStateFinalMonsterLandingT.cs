using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685D RID: 26717
	public class IBattleStateFinalMonsterLandingT
	{
		// Token: 0x1700C46E RID: 50286
		// (get) Token: 0x0602DABE RID: 187070 RVA: 0x0063F2DA File Offset: 0x0063D4DA
		// (set) Token: 0x0602DABF RID: 187071 RVA: 0x0063F2E2 File Offset: 0x0063D4E2
		public ESetBattleTagType Type { get; set; }

		// Token: 0x0602DAC0 RID: 187072 RVA: 0x0063F2EB File Offset: 0x0063D4EB
		public IBattleStateFinalMonsterLandingT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
