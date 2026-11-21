using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AD0 RID: 23248
	public class IFauxPhysicsAxisRotateParam : IFauxPhysicsRotateParam
	{
		// Token: 0x17006CF2 RID: 27890
		// (get) Token: 0x06039365 RID: 234341 RVA: 0x0100661C File Offset: 0x0100481C
		// (set) Token: 0x06039366 RID: 234342 RVA: 0x01006624 File Offset: 0x01004824
		public FVector? LocalRotationAxis { get; set; }

		// Token: 0x17006CF3 RID: 27891
		// (get) Token: 0x06039367 RID: 234343 RVA: 0x0100662D File Offset: 0x0100482D
		// (set) Token: 0x06039368 RID: 234344 RVA: 0x01006635 File Offset: 0x01004835
		public float? AngularForceRadians { get; set; }

		// Token: 0x17006CF4 RID: 27892
		// (get) Token: 0x06039369 RID: 234345 RVA: 0x0100663E File Offset: 0x0100483E
		// (set) Token: 0x0603936A RID: 234346 RVA: 0x01006646 File Offset: 0x01004846
		public float? AngularImpulseRadians { get; set; }

		// Token: 0x17006CF5 RID: 27893
		// (get) Token: 0x0603936B RID: 234347 RVA: 0x0100664F File Offset: 0x0100484F
		// (set) Token: 0x0603936C RID: 234348 RVA: 0x01006657 File Offset: 0x01004857
		public float? AngleMovementRadians { get; set; }

		// Token: 0x17006CF6 RID: 27894
		// (get) Token: 0x0603936D RID: 234349 RVA: 0x01006660 File Offset: 0x01004860
		// (set) Token: 0x0603936E RID: 234350 RVA: 0x01006668 File Offset: 0x01004868
		public EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x17006CF7 RID: 27895
		// (get) Token: 0x0603936F RID: 234351 RVA: 0x01006671 File Offset: 0x01004871
		// (set) Token: 0x06039370 RID: 234352 RVA: 0x01006679 File Offset: 0x01004879
		public FVector? Origin { get; set; }

		// Token: 0x17006CF8 RID: 27896
		// (get) Token: 0x06039371 RID: 234353 RVA: 0x01006682 File Offset: 0x01004882
		// (set) Token: 0x06039372 RID: 234354 RVA: 0x0100668A File Offset: 0x0100488A
		public FVector? RelativeOffset { get; set; }

		// Token: 0x17006CF9 RID: 27897
		// (get) Token: 0x06039373 RID: 234355 RVA: 0x01006693 File Offset: 0x01004893
		// (set) Token: 0x06039374 RID: 234356 RVA: 0x0100669B File Offset: 0x0100489B
		public FVector? Force { get; set; }

		// Token: 0x17006CFA RID: 27898
		// (get) Token: 0x06039375 RID: 234357 RVA: 0x010066A4 File Offset: 0x010048A4
		// (set) Token: 0x06039376 RID: 234358 RVA: 0x010066AC File Offset: 0x010048AC
		public FVector? Impulse { get; set; }

		// Token: 0x17006CFB RID: 27899
		// (get) Token: 0x06039377 RID: 234359 RVA: 0x010066B5 File Offset: 0x010048B5
		// (set) Token: 0x06039378 RID: 234360 RVA: 0x010066BD File Offset: 0x010048BD
		public FVector? Movement { get; set; }
	}
}
