using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C75 RID: 19573
	[NullableContext(2)]
	[Nullable(0)]
	public class MergeHeadStateInfo
	{
		// Token: 0x04019E0A RID: 105994
		public int Id;

		// Token: 0x04019E0B RID: 105995
		public long? TreeId;

		// Token: 0x04019E0C RID: 105996
		public int NodeId;

		// Token: 0x04019E0D RID: 105997
		public string MonsterGroupName;

		// Token: 0x04019E0E RID: 105998
		public IMonsterMergedHpBarSettings MonsterMergedHpBarSettings;

		// Token: 0x04019E0F RID: 105999
		public bool IsVisible;

		// Token: 0x04019E10 RID: 106000
		public float TotalHp;

		// Token: 0x04019E11 RID: 106001
		public float TotalHpMax;

		// Token: 0x04019E12 RID: 106002
		[Nullable(1)]
		public Dictionary<int, MergeHeadStateMonsterInfo> MonsterInfos = new Dictionary<int, MergeHeadStateMonsterInfo>();
	}
}
