using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C93 RID: 23699
	[NullableContext(2)]
	[Nullable(0)]
	public class MergeHeadStateInfo
	{
		// Token: 0x0401F351 RID: 127825
		public int Id;

		// Token: 0x0401F352 RID: 127826
		public long? TreeId;

		// Token: 0x0401F353 RID: 127827
		public int NodeId;

		// Token: 0x0401F354 RID: 127828
		public string MonsterGroupName;

		// Token: 0x0401F355 RID: 127829
		public IMonsterMergedHpBarSettings MonsterMergedHpBarSettings;

		// Token: 0x0401F356 RID: 127830
		public bool IsVisible;

		// Token: 0x0401F357 RID: 127831
		public float TotalHp;

		// Token: 0x0401F358 RID: 127832
		public float TotalHpMax;

		// Token: 0x0401F359 RID: 127833
		[Nullable(1)]
		public Dictionary<int, MergeHeadStateMonsterInfo> MonsterInfos = new Dictionary<int, MergeHeadStateMonsterInfo>();
	}
}
