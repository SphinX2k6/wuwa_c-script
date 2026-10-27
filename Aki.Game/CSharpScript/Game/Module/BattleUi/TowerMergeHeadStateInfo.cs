using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA4 RID: 23716
	public class TowerMergeHeadStateInfo
	{
		// Token: 0x0401F445 RID: 128069
		public int MainMonsterInfoId;

		// Token: 0x0401F446 RID: 128070
		public bool IsVisible;

		// Token: 0x0401F447 RID: 128071
		public float TotalHp;

		// Token: 0x0401F448 RID: 128072
		public float TotalHpMax;

		// Token: 0x0401F449 RID: 128073
		[Nullable(1)]
		public Dictionary<int, TowerMergeHeadStateMonsterInfo> MonsterInfos = new Dictionary<int, TowerMergeHeadStateMonsterInfo>();
	}
}
