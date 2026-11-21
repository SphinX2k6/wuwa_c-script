using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AE2 RID: 23266
	[NullableContext(2)]
	public interface ICurveFloatRange
	{
		// Token: 0x17006D1B RID: 27931
		// (get) Token: 0x060393FA RID: 234490
		// (set) Token: 0x060393FB RID: 234491
		UCurveFloat CurveFloat { get; set; }

		// Token: 0x17006D1C RID: 27932
		// (get) Token: 0x060393FC RID: 234492
		// (set) Token: 0x060393FD RID: 234493
		EEasingType EasingType { get; set; }

		// Token: 0x17006D1D RID: 27933
		// (get) Token: 0x060393FE RID: 234494
		// (set) Token: 0x060393FF RID: 234495
		ECurveSourceType SourceType { get; set; }

		// Token: 0x17006D1E RID: 27934
		// (get) Token: 0x06039400 RID: 234496
		// (set) Token: 0x06039401 RID: 234497
		float FromMin { get; set; }

		// Token: 0x17006D1F RID: 27935
		// (get) Token: 0x06039402 RID: 234498
		// (set) Token: 0x06039403 RID: 234499
		float FromMax { get; set; }

		// Token: 0x17006D20 RID: 27936
		// (get) Token: 0x06039404 RID: 234500
		// (set) Token: 0x06039405 RID: 234501
		float ToMin { get; set; }

		// Token: 0x17006D21 RID: 27937
		// (get) Token: 0x06039406 RID: 234502
		// (set) Token: 0x06039407 RID: 234503
		float ToMax { get; set; }
	}
}
