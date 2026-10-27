using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A2 RID: 30114
	public class IVisualNovelPerformanceCgMoveT
	{
		// Token: 0x1700E465 RID: 58469
		// (get) Token: 0x06036CC2 RID: 224450 RVA: 0x007704B6 File Offset: 0x0076E6B6
		// (set) Token: 0x06036CC3 RID: 224451 RVA: 0x007704BE File Offset: 0x0076E6BE
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E466 RID: 58470
		// (get) Token: 0x06036CC4 RID: 224452 RVA: 0x007704C7 File Offset: 0x0076E6C7
		// (set) Token: 0x06036CC5 RID: 224453 RVA: 0x007704CF File Offset: 0x0076E6CF
		public float StartTime { get; set; }

		// Token: 0x1700E467 RID: 58471
		// (get) Token: 0x06036CC6 RID: 224454 RVA: 0x007704D8 File Offset: 0x0076E6D8
		// (set) Token: 0x06036CC7 RID: 224455 RVA: 0x007704E0 File Offset: 0x0076E6E0
		public IVisualNovelPortraitTransformT StartTransform { get; set; }

		// Token: 0x1700E468 RID: 58472
		// (get) Token: 0x06036CC8 RID: 224456 RVA: 0x007704E9 File Offset: 0x0076E6E9
		// (set) Token: 0x06036CC9 RID: 224457 RVA: 0x007704F1 File Offset: 0x0076E6F1
		public IVisualNovelPortraitTransformT TargetTransform { get; set; }

		// Token: 0x1700E469 RID: 58473
		// (get) Token: 0x06036CCA RID: 224458 RVA: 0x007704FA File Offset: 0x0076E6FA
		// (set) Token: 0x06036CCB RID: 224459 RVA: 0x00770502 File Offset: 0x0076E702
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700E46A RID: 58474
		// (get) Token: 0x06036CCC RID: 224460 RVA: 0x0077050B File Offset: 0x0076E70B
		// (set) Token: 0x06036CCD RID: 224461 RVA: 0x00770513 File Offset: 0x0076E713
		public float Duration { get; set; }

		// Token: 0x1700E46B RID: 58475
		// (get) Token: 0x06036CCE RID: 224462 RVA: 0x0077051C File Offset: 0x0076E71C
		// (set) Token: 0x06036CCF RID: 224463 RVA: 0x00770524 File Offset: 0x0076E724
		public byte NullMask { get; set; }

		// Token: 0x06036CD0 RID: 224464 RVA: 0x00770530 File Offset: 0x0076E730
		public IVisualNovelPerformanceCgMoveT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.StartTransform = null;
			this.TargetTransform = null;
			this.EaseCurve = null;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
