using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02006E1C RID: 28188
	[NullableContext(2)]
	public interface IGravityFlipViewOpenParam
	{
		// Token: 0x170099FB RID: 39419
		// (get) Token: 0x06044B94 RID: 281492
		// (set) Token: 0x06044B95 RID: 281493
		Action<int> SelectCallback { get; set; }
	}
}
