using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02005FD8 RID: 24536
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritMoveParams : ISunSpiritMoveParams
	{
		// Token: 0x17006F58 RID: 28504
		// (get) Token: 0x0603AF13 RID: 241427 RVA: 0x010A8288 File Offset: 0x010A6488
		// (set) Token: 0x0603AF14 RID: 241428 RVA: 0x010A8290 File Offset: 0x010A6490
		public EntityHandle MoveTarget { get; set; }

		// Token: 0x17006F59 RID: 28505
		// (get) Token: 0x0603AF15 RID: 241429 RVA: 0x010A8299 File Offset: 0x010A6499
		// (set) Token: 0x0603AF16 RID: 241430 RVA: 0x010A82A1 File Offset: 0x010A64A1
		public ESunSpiritMovePerformType PerformType { get; set; }

		// Token: 0x17006F5A RID: 28506
		// (get) Token: 0x0603AF17 RID: 241431 RVA: 0x010A82AA File Offset: 0x010A64AA
		// (set) Token: 0x0603AF18 RID: 241432 RVA: 0x010A82B2 File Offset: 0x010A64B2
		public Vector TargetLocation { get; set; }

		// Token: 0x17006F5B RID: 28507
		// (get) Token: 0x0603AF19 RID: 241433 RVA: 0x010A82BB File Offset: 0x010A64BB
		// (set) Token: 0x0603AF1A RID: 241434 RVA: 0x010A82C3 File Offset: 0x010A64C3
		public Rotator TargetRotator { get; set; }

		// Token: 0x17006F5C RID: 28508
		// (get) Token: 0x0603AF1B RID: 241435 RVA: 0x010A82CC File Offset: 0x010A64CC
		// (set) Token: 0x0603AF1C RID: 241436 RVA: 0x010A82D4 File Offset: 0x010A64D4
		public bool? SuccessPerform { get; set; }
	}
}
