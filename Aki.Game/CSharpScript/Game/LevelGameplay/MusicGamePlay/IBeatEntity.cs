using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.MusicGamePlay
{
	// Token: 0x02006AC2 RID: 27330
	[NullableContext(1)]
	public interface IBeatEntity
	{
		// Token: 0x1700996D RID: 39277
		// (get) Token: 0x06043E98 RID: 278168
		// (set) Token: 0x06043E99 RID: 278169
		string Archetype { get; set; }

		// Token: 0x1700996E RID: 39278
		// (get) Token: 0x06043E9A RID: 278170
		// (set) Token: 0x06043E9B RID: 278171
		IBeatData[] Data { get; set; }
	}
}
