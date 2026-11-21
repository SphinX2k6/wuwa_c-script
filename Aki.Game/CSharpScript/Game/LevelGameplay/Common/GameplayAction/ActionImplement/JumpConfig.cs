using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060AF RID: 24751
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpConfig : IJumpConfig, IMoveConfig
	{
		// Token: 0x17007057 RID: 28759
		// (get) Token: 0x0603B59D RID: 243101 RVA: 0x010CC377 File Offset: 0x010CA577
		// (set) Token: 0x0603B59E RID: 243102 RVA: 0x010CC37F File Offset: 0x010CA57F
		public float RotateSpeed { get; set; }

		// Token: 0x17007058 RID: 28760
		// (get) Token: 0x0603B59F RID: 243103 RVA: 0x010CC388 File Offset: 0x010CA588
		// (set) Token: 0x0603B5A0 RID: 243104 RVA: 0x010CC390 File Offset: 0x010CA590
		public float JumpTime { get; set; }

		// Token: 0x17007059 RID: 28761
		// (get) Token: 0x0603B5A1 RID: 243105 RVA: 0x010CC399 File Offset: 0x010CA599
		// (set) Token: 0x0603B5A2 RID: 243106 RVA: 0x010CC3A1 File Offset: 0x010CA5A1
		public float MoveBaseHeightOffset { get; set; }

		// Token: 0x1700705A RID: 28762
		// (get) Token: 0x0603B5A3 RID: 243107 RVA: 0x010CC3AA File Offset: 0x010CA5AA
		// (set) Token: 0x0603B5A4 RID: 243108 RVA: 0x010CC3B2 File Offset: 0x010CA5B2
		public float MaxRiseHeightEdge { get; set; }

		// Token: 0x1700705B RID: 28763
		// (get) Token: 0x0603B5A5 RID: 243109 RVA: 0x010CC3BB File Offset: 0x010CA5BB
		// (set) Token: 0x0603B5A6 RID: 243110 RVA: 0x010CC3C3 File Offset: 0x010CA5C3
		public float MaxFallHeightEdge { get; set; }

		// Token: 0x1700705C RID: 28764
		// (get) Token: 0x0603B5A7 RID: 243111 RVA: 0x010CC3CC File Offset: 0x010CA5CC
		// (set) Token: 0x0603B5A8 RID: 243112 RVA: 0x010CC3D4 File Offset: 0x010CA5D4
		public UCurveFloat MoveRiseCurve { get; set; }

		// Token: 0x1700705D RID: 28765
		// (get) Token: 0x0603B5A9 RID: 243113 RVA: 0x010CC3DD File Offset: 0x010CA5DD
		// (set) Token: 0x0603B5AA RID: 243114 RVA: 0x010CC3E5 File Offset: 0x010CA5E5
		public UCurveFloat MoveFallCurve { get; set; }
	}
}
