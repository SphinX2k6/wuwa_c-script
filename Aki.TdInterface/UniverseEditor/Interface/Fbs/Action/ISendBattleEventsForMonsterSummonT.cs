using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007727 RID: 30503
	public class ISendBattleEventsForMonsterSummonT
	{
		// Token: 0x1700DFA9 RID: 57257
		// (get) Token: 0x06035859 RID: 219225 RVA: 0x0072CC7B File Offset: 0x0072AE7B
		// (set) Token: 0x0603585A RID: 219226 RVA: 0x0072CC83 File Offset: 0x0072AE83
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700DFAA RID: 57258
		// (get) Token: 0x0603585B RID: 219227 RVA: 0x0072CC8C File Offset: 0x0072AE8C
		// (set) Token: 0x0603585C RID: 219228 RVA: 0x0072CC94 File Offset: 0x0072AE94
		public List<ISendBattleEventsForMonsterSummonConfigT> Configs { get; set; }

		// Token: 0x0603585D RID: 219229 RVA: 0x0072CC9D File Offset: 0x0072AE9D
		public ISendBattleEventsForMonsterSummonT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.Configs = null;
		}
	}
}
