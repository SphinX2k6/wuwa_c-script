using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA1 RID: 28065
	public class IExitMonsterMoveWithSplineT
	{
		// Token: 0x1700CDD2 RID: 52690
		// (get) Token: 0x0603071F RID: 198431 RVA: 0x00694E47 File Offset: 0x00693047
		// (set) Token: 0x06030720 RID: 198432 RVA: 0x00694E4F File Offset: 0x0069304F
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700CDD3 RID: 52691
		// (get) Token: 0x06030721 RID: 198433 RVA: 0x00694E58 File Offset: 0x00693058
		// (set) Token: 0x06030722 RID: 198434 RVA: 0x00694E60 File Offset: 0x00693060
		public List<int> TargetEntities { get; set; }

		// Token: 0x06030723 RID: 198435 RVA: 0x00694E69 File Offset: 0x00693069
		public IExitMonsterMoveWithSplineT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.TargetEntities = null;
		}
	}
}
