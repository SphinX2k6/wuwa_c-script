using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.MusicGamePlay
{
	// Token: 0x02005C3A RID: 23610
	[NullableContext(1)]
	public interface IBeatEntity
	{
		// Token: 0x17006E70 RID: 28272
		// (get) Token: 0x06039FE1 RID: 237537
		// (set) Token: 0x06039FE2 RID: 237538
		string Archetype { get; set; }

		// Token: 0x17006E71 RID: 28273
		// (get) Token: 0x06039FE3 RID: 237539
		// (set) Token: 0x06039FE4 RID: 237540
		IBeatData[] Data { get; set; }
	}
}
