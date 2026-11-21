using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F44 RID: 24388
	[NullableContext(1)]
	[Nullable(0)]
	internal class TurnAndPlayMontageParam : ActionParams
	{
		// Token: 0x17006EBF RID: 28351
		// (get) Token: 0x0603AA3E RID: 240190 RVA: 0x01092909 File Offset: 0x01090B09
		// (set) Token: 0x0603AA3F RID: 240191 RVA: 0x01092911 File Offset: 0x01090B11
		public int EntityId { get; set; }

		// Token: 0x17006EC0 RID: 28352
		// (get) Token: 0x0603AA40 RID: 240192 RVA: 0x0109291A File Offset: 0x01090B1A
		// (set) Token: 0x0603AA41 RID: 240193 RVA: 0x01092922 File Offset: 0x01090B22
		public IVector Pos { get; set; }

		// Token: 0x17006EC1 RID: 28353
		// (get) Token: 0x0603AA42 RID: 240194 RVA: 0x0109292B File Offset: 0x01090B2B
		// (set) Token: 0x0603AA43 RID: 240195 RVA: 0x01092933 File Offset: 0x01090B33
		public int MontageId { get; set; }

		// Token: 0x17006EC2 RID: 28354
		// (get) Token: 0x0603AA44 RID: 240196 RVA: 0x0109293C File Offset: 0x01090B3C
		// (set) Token: 0x0603AA45 RID: 240197 RVA: 0x01092944 File Offset: 0x01090B44
		public bool? IsAbpMontage { get; set; }

		// Token: 0x17006EC3 RID: 28355
		// (get) Token: 0x0603AA46 RID: 240198 RVA: 0x0109294D File Offset: 0x01090B4D
		// (set) Token: 0x0603AA47 RID: 240199 RVA: 0x01092955 File Offset: 0x01090B55
		public float LoopDuration { get; set; }

		// Token: 0x17006EC4 RID: 28356
		// (get) Token: 0x0603AA48 RID: 240200 RVA: 0x0109295E File Offset: 0x01090B5E
		// (set) Token: 0x0603AA49 RID: 240201 RVA: 0x01092966 File Offset: 0x01090B66
		public int RepeatTimes { get; set; }
	}
}
