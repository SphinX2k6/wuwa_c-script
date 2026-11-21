using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778D RID: 30605
	public class ISetBattleTagTypeT
	{
		// Token: 0x1700E046 RID: 57414
		// (get) Token: 0x06035B98 RID: 220056 RVA: 0x00732DFE File Offset: 0x00730FFE
		// (set) Token: 0x06035B99 RID: 220057 RVA: 0x00732E06 File Offset: 0x00731006
		public ESetBattleTagType Type { get; set; }

		// Token: 0x06035B9A RID: 220058 RVA: 0x00732E0F File Offset: 0x0073100F
		public ISetBattleTagTypeT()
		{
			this.Type = ESetBattleTagType.BattleMonsterLanding;
		}
	}
}
