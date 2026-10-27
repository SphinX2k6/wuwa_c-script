using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F64 RID: 28516
	public class ISendBattleEventsForMonsterSummonT
	{
		// Token: 0x1700D3DD RID: 54237
		// (get) Token: 0x0603261B RID: 206363 RVA: 0x006CD43B File Offset: 0x006CB63B
		// (set) Token: 0x0603261C RID: 206364 RVA: 0x006CD443 File Offset: 0x006CB643
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700D3DE RID: 54238
		// (get) Token: 0x0603261D RID: 206365 RVA: 0x006CD44C File Offset: 0x006CB64C
		// (set) Token: 0x0603261E RID: 206366 RVA: 0x006CD454 File Offset: 0x006CB654
		public List<ISendBattleEventsForMonsterSummonConfigT> Configs { get; set; }

		// Token: 0x0603261F RID: 206367 RVA: 0x006CD45D File Offset: 0x006CB65D
		public ISendBattleEventsForMonsterSummonT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.Configs = null;
		}
	}
}
