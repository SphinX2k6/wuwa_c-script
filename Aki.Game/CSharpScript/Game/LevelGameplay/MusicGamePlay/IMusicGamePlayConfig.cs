using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.MusicGamePlay
{
	// Token: 0x02005C3B RID: 23611
	[NullableContext(1)]
	public interface IMusicGamePlayConfig
	{
		// Token: 0x17006E72 RID: 28274
		// (get) Token: 0x06039FE5 RID: 237541
		// (set) Token: 0x06039FE6 RID: 237542
		float BgmOffset { get; set; }

		// Token: 0x17006E73 RID: 28275
		// (get) Token: 0x06039FE7 RID: 237543
		// (set) Token: 0x06039FE8 RID: 237544
		IBeatEntity[] Entities { get; set; }
	}
}
