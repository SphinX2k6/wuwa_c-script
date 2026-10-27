using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED4 RID: 20180
	[NullableContext(1)]
	public interface IRogueBattleMapFetterDescInfo
	{
		// Token: 0x17007F17 RID: 32535
		// (get) Token: 0x06033CC5 RID: 212165
		// (set) Token: 0x06033CC6 RID: 212166
		string TextId { get; set; }

		// Token: 0x17007F18 RID: 32536
		// (get) Token: 0x06033CC7 RID: 212167
		// (set) Token: 0x06033CC8 RID: 212168
		[Nullable(2)]
		string Param { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007F19 RID: 32537
		// (get) Token: 0x06033CC9 RID: 212169
		// (set) Token: 0x06033CCA RID: 212170
		bool IsReached { get; set; }

		// Token: 0x17007F1A RID: 32538
		// (get) Token: 0x06033CCB RID: 212171
		// (set) Token: 0x06033CCC RID: 212172
		ERogueResBondEffectType EffectType { get; set; }
	}
}
