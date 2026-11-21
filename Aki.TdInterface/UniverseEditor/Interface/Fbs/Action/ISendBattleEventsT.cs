using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007724 RID: 30500
	public class ISendBattleEventsT
	{
		// Token: 0x1700DFA4 RID: 57252
		// (get) Token: 0x0603583D RID: 219197 RVA: 0x0072C8CF File Offset: 0x0072AACF
		// (set) Token: 0x0603583E RID: 219198 RVA: 0x0072C8D7 File Offset: 0x0072AAD7
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700DFA5 RID: 57253
		// (get) Token: 0x0603583F RID: 219199 RVA: 0x0072C8E0 File Offset: 0x0072AAE0
		// (set) Token: 0x06035840 RID: 219200 RVA: 0x0072C8E8 File Offset: 0x0072AAE8
		public List<ISetBattleTagConfigT> Configs { get; set; }

		// Token: 0x06035841 RID: 219201 RVA: 0x0072C8F1 File Offset: 0x0072AAF1
		public ISendBattleEventsT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.Configs = null;
		}
	}
}
