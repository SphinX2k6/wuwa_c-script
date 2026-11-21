using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D9B RID: 32155
	public class IVisualNovelPerformanceCgMoveT
	{
		// Token: 0x1700F092 RID: 61586
		// (get) Token: 0x0603A0F0 RID: 237808 RVA: 0x007D3A36 File Offset: 0x007D1C36
		// (set) Token: 0x0603A0F1 RID: 237809 RVA: 0x007D3A3E File Offset: 0x007D1C3E
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F093 RID: 61587
		// (get) Token: 0x0603A0F2 RID: 237810 RVA: 0x007D3A47 File Offset: 0x007D1C47
		// (set) Token: 0x0603A0F3 RID: 237811 RVA: 0x007D3A4F File Offset: 0x007D1C4F
		public float StartTime { get; set; }

		// Token: 0x1700F094 RID: 61588
		// (get) Token: 0x0603A0F4 RID: 237812 RVA: 0x007D3A58 File Offset: 0x007D1C58
		// (set) Token: 0x0603A0F5 RID: 237813 RVA: 0x007D3A60 File Offset: 0x007D1C60
		public IVisualNovelPortraitTransformT StartTransform { get; set; }

		// Token: 0x1700F095 RID: 61589
		// (get) Token: 0x0603A0F6 RID: 237814 RVA: 0x007D3A69 File Offset: 0x007D1C69
		// (set) Token: 0x0603A0F7 RID: 237815 RVA: 0x007D3A71 File Offset: 0x007D1C71
		public IVisualNovelPortraitTransformT TargetTransform { get; set; }

		// Token: 0x1700F096 RID: 61590
		// (get) Token: 0x0603A0F8 RID: 237816 RVA: 0x007D3A7A File Offset: 0x007D1C7A
		// (set) Token: 0x0603A0F9 RID: 237817 RVA: 0x007D3A82 File Offset: 0x007D1C82
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700F097 RID: 61591
		// (get) Token: 0x0603A0FA RID: 237818 RVA: 0x007D3A8B File Offset: 0x007D1C8B
		// (set) Token: 0x0603A0FB RID: 237819 RVA: 0x007D3A93 File Offset: 0x007D1C93
		public float Duration { get; set; }

		// Token: 0x1700F098 RID: 61592
		// (get) Token: 0x0603A0FC RID: 237820 RVA: 0x007D3A9C File Offset: 0x007D1C9C
		// (set) Token: 0x0603A0FD RID: 237821 RVA: 0x007D3AA4 File Offset: 0x007D1CA4
		public byte NullMask { get; set; }

		// Token: 0x0603A0FE RID: 237822 RVA: 0x007D3AB0 File Offset: 0x007D1CB0
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
