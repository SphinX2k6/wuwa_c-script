using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E9D RID: 16029
	[NullableContext(1)]
	public interface IRogueBattleMapFetterDescInfo
	{
		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x06028B30 RID: 166704
		// (set) Token: 0x06028B31 RID: 166705
		string TextId { get; set; }

		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x06028B32 RID: 166706
		// (set) Token: 0x06028B33 RID: 166707
		[Nullable(2)]
		string Param { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x06028B34 RID: 166708
		// (set) Token: 0x06028B35 RID: 166709
		bool IsReached { get; set; }

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x06028B36 RID: 166710
		// (set) Token: 0x06028B37 RID: 166711
		ERogueResBondEffectType EffectType { get; set; }
	}
}
