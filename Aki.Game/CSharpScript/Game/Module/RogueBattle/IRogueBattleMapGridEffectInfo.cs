using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA1 RID: 16033
	[NullableContext(1)]
	public interface IRogueBattleMapGridEffectInfo
	{
		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x06028B4E RID: 166734
		// (set) Token: 0x06028B4F RID: 166735
		string TagKey { get; set; }

		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x06028B50 RID: 166736
		// (set) Token: 0x06028B51 RID: 166737
		int Count { get; set; }

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x06028B52 RID: 166738
		// (set) Token: 0x06028B53 RID: 166739
		bool IsRatio { get; set; }

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x06028B54 RID: 166740
		// (set) Token: 0x06028B55 RID: 166741
		string Icon { get; set; }
	}
}
