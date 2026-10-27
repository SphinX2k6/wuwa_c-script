using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F4A RID: 28490
	[NullableContext(1)]
	public interface IBrokenRockJsonConfig
	{
		// Token: 0x17009B57 RID: 39767
		// (get) Token: 0x060454F8 RID: 283896
		// (set) Token: 0x060454F9 RID: 283897
		BrokenRockConfig[] Config { get; set; }

		// Token: 0x17009B58 RID: 39768
		// (get) Token: 0x060454FA RID: 283898
		// (set) Token: 0x060454FB RID: 283899
		BrokenRockRingConfig[] Rings { get; set; }
	}
}
