using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.MusicGamePlay
{
	// Token: 0x02006AC3 RID: 27331
	[NullableContext(1)]
	public interface IMusicGamePlayConfig
	{
		// Token: 0x1700996F RID: 39279
		// (get) Token: 0x06043E9C RID: 278172
		// (set) Token: 0x06043E9D RID: 278173
		float BgmOffset { get; set; }

		// Token: 0x17009970 RID: 39280
		// (get) Token: 0x06043E9E RID: 278174
		// (set) Token: 0x06043E9F RID: 278175
		IBeatEntity[] Entities { get; set; }
	}
}
