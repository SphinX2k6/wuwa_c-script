using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701D RID: 28701
	public class ISetMonsterMoveWithSplineT
	{
		// Token: 0x1700D521 RID: 54561
		// (get) Token: 0x06032C4F RID: 207951 RVA: 0x006D961B File Offset: 0x006D781B
		// (set) Token: 0x06032C50 RID: 207952 RVA: 0x006D9623 File Offset: 0x006D7823
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700D522 RID: 54562
		// (get) Token: 0x06032C51 RID: 207953 RVA: 0x006D962C File Offset: 0x006D782C
		// (set) Token: 0x06032C52 RID: 207954 RVA: 0x006D9634 File Offset: 0x006D7834
		public List<IMonsterMoveSplineConfigT> MoveSplineConfigs { get; set; }

		// Token: 0x06032C53 RID: 207955 RVA: 0x006D963D File Offset: 0x006D783D
		public ISetMonsterMoveWithSplineT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.MoveSplineConfigs = null;
		}
	}
}
