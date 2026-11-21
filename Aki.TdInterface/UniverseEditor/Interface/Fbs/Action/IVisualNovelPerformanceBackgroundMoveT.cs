using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D92 RID: 32146
	public class IVisualNovelPerformanceBackgroundMoveT
	{
		// Token: 0x1700F07A RID: 61562
		// (get) Token: 0x0603A07E RID: 237694 RVA: 0x007D2B22 File Offset: 0x007D0D22
		// (set) Token: 0x0603A07F RID: 237695 RVA: 0x007D2B2A File Offset: 0x007D0D2A
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F07B RID: 61563
		// (get) Token: 0x0603A080 RID: 237696 RVA: 0x007D2B33 File Offset: 0x007D0D33
		// (set) Token: 0x0603A081 RID: 237697 RVA: 0x007D2B3B File Offset: 0x007D0D3B
		public float StartTime { get; set; }

		// Token: 0x1700F07C RID: 61564
		// (get) Token: 0x0603A082 RID: 237698 RVA: 0x007D2B44 File Offset: 0x007D0D44
		// (set) Token: 0x0603A083 RID: 237699 RVA: 0x007D2B4C File Offset: 0x007D0D4C
		public IVisualNovelPortraitTransformT StartTransform { get; set; }

		// Token: 0x1700F07D RID: 61565
		// (get) Token: 0x0603A084 RID: 237700 RVA: 0x007D2B55 File Offset: 0x007D0D55
		// (set) Token: 0x0603A085 RID: 237701 RVA: 0x007D2B5D File Offset: 0x007D0D5D
		public IVisualNovelPortraitTransformT TargetTransform { get; set; }

		// Token: 0x1700F07E RID: 61566
		// (get) Token: 0x0603A086 RID: 237702 RVA: 0x007D2B66 File Offset: 0x007D0D66
		// (set) Token: 0x0603A087 RID: 237703 RVA: 0x007D2B6E File Offset: 0x007D0D6E
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700F07F RID: 61567
		// (get) Token: 0x0603A088 RID: 237704 RVA: 0x007D2B77 File Offset: 0x007D0D77
		// (set) Token: 0x0603A089 RID: 237705 RVA: 0x007D2B7F File Offset: 0x007D0D7F
		public float Duration { get; set; }

		// Token: 0x1700F080 RID: 61568
		// (get) Token: 0x0603A08A RID: 237706 RVA: 0x007D2B88 File Offset: 0x007D0D88
		// (set) Token: 0x0603A08B RID: 237707 RVA: 0x007D2B90 File Offset: 0x007D0D90
		public byte NullMask { get; set; }

		// Token: 0x0603A08C RID: 237708 RVA: 0x007D2B9C File Offset: 0x007D0D9C
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
