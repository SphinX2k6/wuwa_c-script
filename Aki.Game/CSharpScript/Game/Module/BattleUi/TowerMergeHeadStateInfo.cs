using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C86 RID: 19590
	public class TowerMergeHeadStateInfo
	{
		// Token: 0x04019EFE RID: 106238
		public int MainMonsterInfoId;

		// Token: 0x04019EFF RID: 106239
		public bool IsVisible;

		// Token: 0x04019F00 RID: 106240
		public float TotalHp;

		// Token: 0x04019F01 RID: 106241
		public float TotalHpMax;

		// Token: 0x04019F02 RID: 106242
		[Nullable(1)]
		public Dictionary<int, TowerMergeHeadStateMonsterInfo> MonsterInfos = new Dictionary<int, TowerMergeHeadStateMonsterInfo>();
	}
}
