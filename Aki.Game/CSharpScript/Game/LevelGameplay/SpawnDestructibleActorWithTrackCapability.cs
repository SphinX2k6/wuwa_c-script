using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AD9 RID: 23257
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnDestructibleActorWithTrackCapability
	{
		// Token: 0x17006D0B RID: 27915
		// (get) Token: 0x0603939E RID: 234398 RVA: 0x01006803 File Offset: 0x01004A03
		// (set) Token: 0x0603939F RID: 234399 RVA: 0x0100680B File Offset: 0x01004A0B
		public string KuroDestructibleAsset { get; set; }

		// Token: 0x17006D0C RID: 27916
		// (get) Token: 0x060393A0 RID: 234400 RVA: 0x01006814 File Offset: 0x01004A14
		// (set) Token: 0x060393A1 RID: 234401 RVA: 0x0100681C File Offset: 0x01004A1C
		public string KuroDestructibleDestructionAsset { get; set; }

		// Token: 0x17006D0D RID: 27917
		// (get) Token: 0x060393A2 RID: 234402 RVA: 0x01006825 File Offset: 0x01004A25
		// (set) Token: 0x060393A3 RID: 234403 RVA: 0x0100682D File Offset: 0x01004A2D
		public FTransformDouble StartTransform { get; set; }

		// Token: 0x17006D0E RID: 27918
		// (get) Token: 0x060393A4 RID: 234404 RVA: 0x01006836 File Offset: 0x01004A36
		// (set) Token: 0x060393A5 RID: 234405 RVA: 0x0100683E File Offset: 0x01004A3E
		public float TrackSpeed { get; set; }

		// Token: 0x17006D0F RID: 27919
		// (get) Token: 0x060393A6 RID: 234406 RVA: 0x01006847 File Offset: 0x01004A47
		// (set) Token: 0x060393A7 RID: 234407 RVA: 0x0100684F File Offset: 0x01004A4F
		public ETrackMethod TrackMethod { get; set; }

		// Token: 0x17006D10 RID: 27920
		// (get) Token: 0x060393A8 RID: 234408 RVA: 0x01006858 File Offset: 0x01004A58
		// (set) Token: 0x060393A9 RID: 234409 RVA: 0x01006860 File Offset: 0x01004A60
		public float TrackPredictionFactor { get; set; }

		// Token: 0x17006D11 RID: 27921
		// (get) Token: 0x060393AA RID: 234410 RVA: 0x01006869 File Offset: 0x01004A69
		// (set) Token: 0x060393AB RID: 234411 RVA: 0x01006871 File Offset: 0x01004A71
		public float StopTrackTargetDistance { get; set; }

		// Token: 0x17006D12 RID: 27922
		// (get) Token: 0x060393AC RID: 234412 RVA: 0x0100687A File Offset: 0x01004A7A
		// (set) Token: 0x060393AD RID: 234413 RVA: 0x01006882 File Offset: 0x01004A82
		[Nullable(2)]
		public APawn TargetToTrack { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006D13 RID: 27923
		// (get) Token: 0x060393AE RID: 234414 RVA: 0x0100688B File Offset: 0x01004A8B
		// (set) Token: 0x060393AF RID: 234415 RVA: 0x01006893 File Offset: 0x01004A93
		public FTransform ModelTransform { get; set; }

		// Token: 0x17006D14 RID: 27924
		// (get) Token: 0x060393B0 RID: 234416 RVA: 0x0100689C File Offset: 0x01004A9C
		// (set) Token: 0x060393B1 RID: 234417 RVA: 0x010068A4 File Offset: 0x01004AA4
		public IFauxPhysicsRotateParam RotateParam { get; set; }

		// Token: 0x17006D15 RID: 27925
		// (get) Token: 0x060393B2 RID: 234418 RVA: 0x010068AD File Offset: 0x01004AAD
		// (set) Token: 0x060393B3 RID: 234419 RVA: 0x010068B5 File Offset: 0x01004AB5
		public int DamageAmount { get; set; }

		// Token: 0x17006D16 RID: 27926
		// (get) Token: 0x060393B4 RID: 234420 RVA: 0x010068BE File Offset: 0x01004ABE
		// (set) Token: 0x060393B5 RID: 234421 RVA: 0x010068C6 File Offset: 0x01004AC6
		public int? HitBuff { get; set; }

		// Token: 0x17006D17 RID: 27927
		// (get) Token: 0x060393B6 RID: 234422 RVA: 0x010068CF File Offset: 0x01004ACF
		// (set) Token: 0x060393B7 RID: 234423 RVA: 0x010068D7 File Offset: 0x01004AD7
		public int? RevertMaxHp { get; set; }
	}
}
