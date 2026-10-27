using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED8 RID: 20184
	[NullableContext(1)]
	public interface IRogueBattleMapGridEffectInfo
	{
		// Token: 0x17007F25 RID: 32549
		// (get) Token: 0x06033CE3 RID: 212195
		// (set) Token: 0x06033CE4 RID: 212196
		string TagKey { get; set; }

		// Token: 0x17007F26 RID: 32550
		// (get) Token: 0x06033CE5 RID: 212197
		// (set) Token: 0x06033CE6 RID: 212198
		int Count { get; set; }

		// Token: 0x17007F27 RID: 32551
		// (get) Token: 0x06033CE7 RID: 212199
		// (set) Token: 0x06033CE8 RID: 212200
		bool IsRatio { get; set; }

		// Token: 0x17007F28 RID: 32552
		// (get) Token: 0x06033CE9 RID: 212201
		// (set) Token: 0x06033CEA RID: 212202
		string Icon { get; set; }
	}
}
