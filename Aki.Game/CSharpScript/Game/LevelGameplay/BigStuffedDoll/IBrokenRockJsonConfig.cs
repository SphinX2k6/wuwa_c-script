using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060CB RID: 24779
	[NullableContext(1)]
	public interface IBrokenRockJsonConfig
	{
		// Token: 0x17007096 RID: 28822
		// (get) Token: 0x0603B6A6 RID: 243366
		// (set) Token: 0x0603B6A7 RID: 243367
		BrokenRockConfig[] Config { get; set; }

		// Token: 0x17007097 RID: 28823
		// (get) Token: 0x0603B6A8 RID: 243368
		// (set) Token: 0x0603B6A9 RID: 243369
		BrokenRockRingConfig[] Rings { get; set; }
	}
}
