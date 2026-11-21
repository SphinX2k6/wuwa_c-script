using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9E RID: 28062
	public class IExitMonsterMoveTargetT
	{
		// Token: 0x1700CDCD RID: 52685
		// (get) Token: 0x06030701 RID: 198401 RVA: 0x00694B1B File Offset: 0x00692D1B
		// (set) Token: 0x06030702 RID: 198402 RVA: 0x00694B23 File Offset: 0x00692D23
		public EExecBattleActionType Type { get; set; }

		// Token: 0x1700CDCE RID: 52686
		// (get) Token: 0x06030703 RID: 198403 RVA: 0x00694B2C File Offset: 0x00692D2C
		// (set) Token: 0x06030704 RID: 198404 RVA: 0x00694B34 File Offset: 0x00692D34
		public List<int> TargetEntities { get; set; }

		// Token: 0x06030705 RID: 198405 RVA: 0x00694B3D File Offset: 0x00692D3D
		public IExitMonsterMoveTargetT()
		{
			this.Type = EExecBattleActionType.SetBattleTags;
			this.TargetEntities = null;
		}
	}
}
