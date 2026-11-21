using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E6 RID: 30694
	public class ISetMonsterMoveWithSplineT
	{
		// Token: 0x1700E0F5 RID: 57589
		// (get) Token: 0x06035EB5 RID: 220853 RVA: 0x0073925F File Offset: 0x0073745F
		// (set) Token: 0x06035EB6 RID: 220854 RVA: 0x00739267 File Offset: 0x00737467
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700E0F6 RID: 57590
		// (get) Token: 0x06035EB7 RID: 220855 RVA: 0x00739270 File Offset: 0x00737470
		// (set) Token: 0x06035EB8 RID: 220856 RVA: 0x00739278 File Offset: 0x00737478
		public List<IMonsterMoveSplineConfigT> MoveSplineConfigs { get; set; }

		// Token: 0x06035EB9 RID: 220857 RVA: 0x00739281 File Offset: 0x00737481
		public ISetMonsterMoveWithSplineT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.MoveSplineConfigs = null;
		}
	}
}
