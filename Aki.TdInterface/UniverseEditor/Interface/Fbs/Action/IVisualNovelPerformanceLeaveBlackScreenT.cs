using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA7 RID: 32167
	public class IVisualNovelPerformanceLeaveBlackScreenT
	{
		// Token: 0x1700F0CA RID: 61642
		// (get) Token: 0x0603A198 RID: 237976 RVA: 0x007D5179 File Offset: 0x007D3379
		// (set) Token: 0x0603A199 RID: 237977 RVA: 0x007D5181 File Offset: 0x007D3381
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0CB RID: 61643
		// (get) Token: 0x0603A19A RID: 237978 RVA: 0x007D518A File Offset: 0x007D338A
		// (set) Token: 0x0603A19B RID: 237979 RVA: 0x007D5192 File Offset: 0x007D3392
		public float StartTime { get; set; }

		// Token: 0x1700F0CC RID: 61644
		// (get) Token: 0x0603A19C RID: 237980 RVA: 0x007D519B File Offset: 0x007D339B
		// (set) Token: 0x0603A19D RID: 237981 RVA: 0x007D51A3 File Offset: 0x007D33A3
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700F0CD RID: 61645
		// (get) Token: 0x0603A19E RID: 237982 RVA: 0x007D51AC File Offset: 0x007D33AC
		// (set) Token: 0x0603A19F RID: 237983 RVA: 0x007D51B4 File Offset: 0x007D33B4
		public float FadeOutTime { get; set; }

		// Token: 0x1700F0CE RID: 61646
		// (get) Token: 0x0603A1A0 RID: 237984 RVA: 0x007D51BD File Offset: 0x007D33BD
		// (set) Token: 0x0603A1A1 RID: 237985 RVA: 0x007D51C5 File Offset: 0x007D33C5
		public byte NullMask { get; set; }

		// Token: 0x0603A1A2 RID: 237986 RVA: 0x007D51CE File Offset: 0x007D33CE
		public IVisualNovelPerformanceLeaveBlackScreenT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.EaseCurve = null;
			this.FadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
