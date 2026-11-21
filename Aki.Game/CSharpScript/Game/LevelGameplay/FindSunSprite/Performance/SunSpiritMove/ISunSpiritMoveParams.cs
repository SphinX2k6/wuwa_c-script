using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02005FD7 RID: 24535
	[NullableContext(1)]
	public interface ISunSpiritMoveParams
	{
		// Token: 0x17006F53 RID: 28499
		// (get) Token: 0x0603AF09 RID: 241417
		// (set) Token: 0x0603AF0A RID: 241418
		EntityHandle MoveTarget { get; set; }

		// Token: 0x17006F54 RID: 28500
		// (get) Token: 0x0603AF0B RID: 241419
		// (set) Token: 0x0603AF0C RID: 241420
		ESunSpiritMovePerformType PerformType { get; set; }

		// Token: 0x17006F55 RID: 28501
		// (get) Token: 0x0603AF0D RID: 241421
		// (set) Token: 0x0603AF0E RID: 241422
		Vector TargetLocation { get; set; }

		// Token: 0x17006F56 RID: 28502
		// (get) Token: 0x0603AF0F RID: 241423
		// (set) Token: 0x0603AF10 RID: 241424
		Rotator TargetRotator { get; set; }

		// Token: 0x17006F57 RID: 28503
		// (get) Token: 0x0603AF11 RID: 241425
		// (set) Token: 0x0603AF12 RID: 241426
		bool? SuccessPerform { get; set; }
	}
}
