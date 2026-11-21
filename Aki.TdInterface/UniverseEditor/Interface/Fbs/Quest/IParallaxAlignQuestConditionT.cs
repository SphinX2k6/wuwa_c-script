using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043AD RID: 17325
	public class IParallaxAlignQuestConditionT
	{
		// Token: 0x170076F0 RID: 30448
		// (get) Token: 0x0601883A RID: 100410 RVA: 0x0037E3C2 File Offset: 0x0037C5C2
		// (set) Token: 0x0601883B RID: 100411 RVA: 0x0037E3CA File Offset: 0x0037C5CA
		public EChildQuest Type { get; set; }

		// Token: 0x170076F1 RID: 30449
		// (get) Token: 0x0601883C RID: 100412 RVA: 0x0037E3D3 File Offset: 0x0037C5D3
		// (set) Token: 0x0601883D RID: 100413 RVA: 0x0037E3DB File Offset: 0x0037C5DB
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170076F2 RID: 30450
		// (get) Token: 0x0601883E RID: 100414 RVA: 0x0037E3E4 File Offset: 0x0037C5E4
		// (set) Token: 0x0601883F RID: 100415 RVA: 0x0037E3EC File Offset: 0x0037C5EC
		public IVectorInfoT SourcePos { get; set; }

		// Token: 0x170076F3 RID: 30451
		// (get) Token: 0x06018840 RID: 100416 RVA: 0x0037E3F5 File Offset: 0x0037C5F5
		// (set) Token: 0x06018841 RID: 100417 RVA: 0x0037E3FD File Offset: 0x0037C5FD
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x170076F4 RID: 30452
		// (get) Token: 0x06018842 RID: 100418 RVA: 0x0037E406 File Offset: 0x0037C606
		// (set) Token: 0x06018843 RID: 100419 RVA: 0x0037E40E File Offset: 0x0037C60E
		public float ErrorRange { get; set; }

		// Token: 0x170076F5 RID: 30453
		// (get) Token: 0x06018844 RID: 100420 RVA: 0x0037E417 File Offset: 0x0037C617
		// (set) Token: 0x06018845 RID: 100421 RVA: 0x0037E41F File Offset: 0x0037C61F
		public List<IParallaxPointPairT> ExtraPairs { get; set; }

		// Token: 0x170076F6 RID: 30454
		// (get) Token: 0x06018846 RID: 100422 RVA: 0x0037E428 File Offset: 0x0037C628
		// (set) Token: 0x06018847 RID: 100423 RVA: 0x0037E430 File Offset: 0x0037C630
		public bool DetectMisaligned { get; set; }

		// Token: 0x170076F7 RID: 30455
		// (get) Token: 0x06018848 RID: 100424 RVA: 0x0037E439 File Offset: 0x0037C639
		// (set) Token: 0x06018849 RID: 100425 RVA: 0x0037E441 File Offset: 0x0037C641
		public int BallEntity { get; set; }

		// Token: 0x170076F8 RID: 30456
		// (get) Token: 0x0601884A RID: 100426 RVA: 0x0037E44A File Offset: 0x0037C64A
		// (set) Token: 0x0601884B RID: 100427 RVA: 0x0037E452 File Offset: 0x0037C652
		public float BrightnessAdjustRange { get; set; }

		// Token: 0x170076F9 RID: 30457
		// (get) Token: 0x0601884C RID: 100428 RVA: 0x0037E45B File Offset: 0x0037C65B
		// (set) Token: 0x0601884D RID: 100429 RVA: 0x0037E463 File Offset: 0x0037C663
		public float DefaultBrightness { get; set; }

		// Token: 0x170076FA RID: 30458
		// (get) Token: 0x0601884E RID: 100430 RVA: 0x0037E46C File Offset: 0x0037C66C
		// (set) Token: 0x0601884F RID: 100431 RVA: 0x0037E474 File Offset: 0x0037C674
		public IColorT FinalColor { get; set; }

		// Token: 0x170076FB RID: 30459
		// (get) Token: 0x06018850 RID: 100432 RVA: 0x0037E47D File Offset: 0x0037C67D
		// (set) Token: 0x06018851 RID: 100433 RVA: 0x0037E485 File Offset: 0x0037C685
		public float FixationTime { get; set; }

		// Token: 0x170076FC RID: 30460
		// (get) Token: 0x06018852 RID: 100434 RVA: 0x0037E48E File Offset: 0x0037C68E
		// (set) Token: 0x06018853 RID: 100435 RVA: 0x0037E496 File Offset: 0x0037C696
		public byte NullMask { get; set; }

		// Token: 0x06018854 RID: 100436 RVA: 0x0037E4A0 File Offset: 0x0037C6A0
		public IParallaxAlignQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SourcePos = null;
			this.TargetPos = null;
			this.ErrorRange = 0f;
			this.ExtraPairs = null;
			this.DetectMisaligned = false;
			this.BallEntity = 0;
			this.BrightnessAdjustRange = 0f;
			this.DefaultBrightness = 0f;
			this.FinalColor = null;
			this.FixationTime = 0f;
			this.NullMask = 0;
		}
	}
}
