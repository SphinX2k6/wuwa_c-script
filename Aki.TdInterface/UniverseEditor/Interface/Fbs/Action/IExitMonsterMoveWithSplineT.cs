using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006721 RID: 26401
	public class IExitMonsterMoveWithSplineT
	{
		// Token: 0x1700C41C RID: 50204
		// (get) Token: 0x0602DED9 RID: 188121 RVA: 0x00647703 File Offset: 0x00645903
		// (set) Token: 0x0602DEDA RID: 188122 RVA: 0x0064770B File Offset: 0x0064590B
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700C41D RID: 50205
		// (get) Token: 0x0602DEDB RID: 188123 RVA: 0x00647714 File Offset: 0x00645914
		// (set) Token: 0x0602DEDC RID: 188124 RVA: 0x0064771C File Offset: 0x0064591C
		public List<int> TargetEntities { get; set; }

		// Token: 0x0602DEDD RID: 188125 RVA: 0x00647725 File Offset: 0x00645925
		public IExitMonsterMoveWithSplineT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.TargetEntities = null;
		}
	}
}
