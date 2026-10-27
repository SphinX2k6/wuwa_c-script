using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F2E RID: 28462
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpConfig : IJumpConfig, IMoveConfig
	{
		// Token: 0x17009B18 RID: 39704
		// (get) Token: 0x060453EF RID: 283631 RVA: 0x011223CB File Offset: 0x011205CB
		// (set) Token: 0x060453F0 RID: 283632 RVA: 0x011223D3 File Offset: 0x011205D3
		public float RotateSpeed { get; set; }

		// Token: 0x17009B19 RID: 39705
		// (get) Token: 0x060453F1 RID: 283633 RVA: 0x011223DC File Offset: 0x011205DC
		// (set) Token: 0x060453F2 RID: 283634 RVA: 0x011223E4 File Offset: 0x011205E4
		public float JumpTime { get; set; }

		// Token: 0x17009B1A RID: 39706
		// (get) Token: 0x060453F3 RID: 283635 RVA: 0x011223ED File Offset: 0x011205ED
		// (set) Token: 0x060453F4 RID: 283636 RVA: 0x011223F5 File Offset: 0x011205F5
		public float MoveBaseHeightOffset { get; set; }

		// Token: 0x17009B1B RID: 39707
		// (get) Token: 0x060453F5 RID: 283637 RVA: 0x011223FE File Offset: 0x011205FE
		// (set) Token: 0x060453F6 RID: 283638 RVA: 0x01122406 File Offset: 0x01120606
		public float MaxRiseHeightEdge { get; set; }

		// Token: 0x17009B1C RID: 39708
		// (get) Token: 0x060453F7 RID: 283639 RVA: 0x0112240F File Offset: 0x0112060F
		// (set) Token: 0x060453F8 RID: 283640 RVA: 0x01122417 File Offset: 0x01120617
		public float MaxFallHeightEdge { get; set; }

		// Token: 0x17009B1D RID: 39709
		// (get) Token: 0x060453F9 RID: 283641 RVA: 0x01122420 File Offset: 0x01120620
		// (set) Token: 0x060453FA RID: 283642 RVA: 0x01122428 File Offset: 0x01120628
		public UCurveFloat MoveRiseCurve { get; set; }

		// Token: 0x17009B1E RID: 39710
		// (get) Token: 0x060453FB RID: 283643 RVA: 0x01122431 File Offset: 0x01120631
		// (set) Token: 0x060453FC RID: 283644 RVA: 0x01122439 File Offset: 0x01120639
		public UCurveFloat MoveFallCurve { get; set; }
	}
}
