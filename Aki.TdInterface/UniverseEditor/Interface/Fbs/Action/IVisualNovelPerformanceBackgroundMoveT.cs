using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007599 RID: 30105
	public class IVisualNovelPerformanceBackgroundMoveT
	{
		// Token: 0x1700E44D RID: 58445
		// (get) Token: 0x06036C4E RID: 224334 RVA: 0x0076F55A File Offset: 0x0076D75A
		// (set) Token: 0x06036C4F RID: 224335 RVA: 0x0076F562 File Offset: 0x0076D762
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E44E RID: 58446
		// (get) Token: 0x06036C50 RID: 224336 RVA: 0x0076F56B File Offset: 0x0076D76B
		// (set) Token: 0x06036C51 RID: 224337 RVA: 0x0076F573 File Offset: 0x0076D773
		public float StartTime { get; set; }

		// Token: 0x1700E44F RID: 58447
		// (get) Token: 0x06036C52 RID: 224338 RVA: 0x0076F57C File Offset: 0x0076D77C
		// (set) Token: 0x06036C53 RID: 224339 RVA: 0x0076F584 File Offset: 0x0076D784
		public IVisualNovelPortraitTransformT StartTransform { get; set; }

		// Token: 0x1700E450 RID: 58448
		// (get) Token: 0x06036C54 RID: 224340 RVA: 0x0076F58D File Offset: 0x0076D78D
		// (set) Token: 0x06036C55 RID: 224341 RVA: 0x0076F595 File Offset: 0x0076D795
		public IVisualNovelPortraitTransformT TargetTransform { get; set; }

		// Token: 0x1700E451 RID: 58449
		// (get) Token: 0x06036C56 RID: 224342 RVA: 0x0076F59E File Offset: 0x0076D79E
		// (set) Token: 0x06036C57 RID: 224343 RVA: 0x0076F5A6 File Offset: 0x0076D7A6
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700E452 RID: 58450
		// (get) Token: 0x06036C58 RID: 224344 RVA: 0x0076F5AF File Offset: 0x0076D7AF
		// (set) Token: 0x06036C59 RID: 224345 RVA: 0x0076F5B7 File Offset: 0x0076D7B7
		public float Duration { get; set; }

		// Token: 0x1700E453 RID: 58451
		// (get) Token: 0x06036C5A RID: 224346 RVA: 0x0076F5C0 File Offset: 0x0076D7C0
		// (set) Token: 0x06036C5B RID: 224347 RVA: 0x0076F5C8 File Offset: 0x0076D7C8
		public byte NullMask { get; set; }

		// Token: 0x06036C5C RID: 224348 RVA: 0x0076F5D4 File Offset: 0x0076D7D4
		public IVisualNovelPerformanceBackgroundMoveT()
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
