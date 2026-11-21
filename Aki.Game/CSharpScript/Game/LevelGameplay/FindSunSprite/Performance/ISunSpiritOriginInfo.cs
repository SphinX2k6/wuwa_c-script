using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance
{
	// Token: 0x02005FD3 RID: 24531
	[NullableContext(1)]
	public interface ISunSpiritOriginInfo
	{
		// Token: 0x17006F4B RID: 28491
		// (get) Token: 0x0603AEE6 RID: 241382
		// (set) Token: 0x0603AEE7 RID: 241383
		EntityHandle EntityHandle { get; set; }

		// Token: 0x17006F4C RID: 28492
		// (get) Token: 0x0603AEE8 RID: 241384
		// (set) Token: 0x0603AEE9 RID: 241385
		Transform Transform { get; set; }

		// Token: 0x17006F4D RID: 28493
		// (get) Token: 0x0603AEEA RID: 241386
		// (set) Token: 0x0603AEEB RID: 241387
		int DisableMoveHandle { get; set; }

		// Token: 0x17006F4E RID: 28494
		// (get) Token: 0x0603AEEC RID: 241388
		// (set) Token: 0x0603AEED RID: 241389
		int DisableMoveTickHandle { get; set; }
	}
}
