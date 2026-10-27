using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671E RID: 26398
	public class IExitMonsterMoveTargetT
	{
		// Token: 0x1700C417 RID: 50199
		// (get) Token: 0x0602DEBB RID: 188091 RVA: 0x006473D7 File Offset: 0x006455D7
		// (set) Token: 0x0602DEBC RID: 188092 RVA: 0x006473DF File Offset: 0x006455DF
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700C418 RID: 50200
		// (get) Token: 0x0602DEBD RID: 188093 RVA: 0x006473E8 File Offset: 0x006455E8
		// (set) Token: 0x0602DEBE RID: 188094 RVA: 0x006473F0 File Offset: 0x006455F0
		public List<int> TargetEntities { get; set; }

		// Token: 0x0602DEBF RID: 188095 RVA: 0x006473F9 File Offset: 0x006455F9
		public IExitMonsterMoveTargetT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.TargetEntities = null;
		}
	}
}
