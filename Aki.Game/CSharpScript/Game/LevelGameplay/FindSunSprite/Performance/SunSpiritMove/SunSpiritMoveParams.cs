using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02006E57 RID: 28247
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritMoveParams : ISunSpiritMoveParams
	{
		// Token: 0x17009A43 RID: 39491
		// (get) Token: 0x06044D86 RID: 281990 RVA: 0x010FDD28 File Offset: 0x010FBF28
		// (set) Token: 0x06044D87 RID: 281991 RVA: 0x010FDD30 File Offset: 0x010FBF30
		public EntityHandle MoveTarget { get; set; }

		// Token: 0x17009A44 RID: 39492
		// (get) Token: 0x06044D88 RID: 281992 RVA: 0x010FDD39 File Offset: 0x010FBF39
		// (set) Token: 0x06044D89 RID: 281993 RVA: 0x010FDD41 File Offset: 0x010FBF41
		public ESunSpiritMovePerformType PerformType { get; set; }

		// Token: 0x17009A45 RID: 39493
		// (get) Token: 0x06044D8A RID: 281994 RVA: 0x010FDD4A File Offset: 0x010FBF4A
		// (set) Token: 0x06044D8B RID: 281995 RVA: 0x010FDD52 File Offset: 0x010FBF52
		public Vector TargetLocation { get; set; }

		// Token: 0x17009A46 RID: 39494
		// (get) Token: 0x06044D8C RID: 281996 RVA: 0x010FDD5B File Offset: 0x010FBF5B
		// (set) Token: 0x06044D8D RID: 281997 RVA: 0x010FDD63 File Offset: 0x010FBF63
		public Rotator TargetRotator { get; set; }

		// Token: 0x17009A47 RID: 39495
		// (get) Token: 0x06044D8E RID: 281998 RVA: 0x010FDD6C File Offset: 0x010FBF6C
		// (set) Token: 0x06044D8F RID: 281999 RVA: 0x010FDD74 File Offset: 0x010FBF74
		public bool? SuccessPerform { get; set; }
	}
}
