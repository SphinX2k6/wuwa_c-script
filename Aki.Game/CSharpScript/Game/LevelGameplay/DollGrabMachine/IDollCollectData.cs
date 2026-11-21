using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006046 RID: 24646
	public interface IDollCollectData
	{
		// Token: 0x17006FEF RID: 28655
		// (get) Token: 0x0603B274 RID: 242292
		// (set) Token: 0x0603B275 RID: 242293
		int CurrentCollectCount { get; set; }

		// Token: 0x17006FF0 RID: 28656
		// (get) Token: 0x0603B276 RID: 242294
		// (set) Token: 0x0603B277 RID: 242295
		int TotalCollectCount { get; set; }

		// Token: 0x17006FF1 RID: 28657
		// (get) Token: 0x0603B278 RID: 242296
		// (set) Token: 0x0603B279 RID: 242297
		int CurrentCollectItemCount { get; set; }

		// Token: 0x17006FF2 RID: 28658
		// (get) Token: 0x0603B27A RID: 242298
		// (set) Token: 0x0603B27B RID: 242299
		int TotalCollectItemCount { get; set; }
	}
}
