using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance
{
	// Token: 0x02005FD4 RID: 24532
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritOriginInfo : ISunSpiritOriginInfo
	{
		// Token: 0x17006F4F RID: 28495
		// (get) Token: 0x0603AEEE RID: 241390 RVA: 0x010A7881 File Offset: 0x010A5A81
		// (set) Token: 0x0603AEEF RID: 241391 RVA: 0x010A7889 File Offset: 0x010A5A89
		public EntityHandle EntityHandle { get; set; }

		// Token: 0x17006F50 RID: 28496
		// (get) Token: 0x0603AEF0 RID: 241392 RVA: 0x010A7892 File Offset: 0x010A5A92
		// (set) Token: 0x0603AEF1 RID: 241393 RVA: 0x010A789A File Offset: 0x010A5A9A
		public Transform Transform { get; set; }

		// Token: 0x17006F51 RID: 28497
		// (get) Token: 0x0603AEF2 RID: 241394 RVA: 0x010A78A3 File Offset: 0x010A5AA3
		// (set) Token: 0x0603AEF3 RID: 241395 RVA: 0x010A78AB File Offset: 0x010A5AAB
		public int DisableMoveHandle { get; set; }

		// Token: 0x17006F52 RID: 28498
		// (get) Token: 0x0603AEF4 RID: 241396 RVA: 0x010A78B4 File Offset: 0x010A5AB4
		// (set) Token: 0x0603AEF5 RID: 241397 RVA: 0x010A78BC File Offset: 0x010A5ABC
		public int DisableMoveTickHandle { get; set; }
	}
}
