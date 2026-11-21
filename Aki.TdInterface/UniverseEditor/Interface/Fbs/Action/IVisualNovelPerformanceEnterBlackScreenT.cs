using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA1 RID: 32161
	public class IVisualNovelPerformanceEnterBlackScreenT
	{
		// Token: 0x1700F0AF RID: 61615
		// (get) Token: 0x0603A146 RID: 237894 RVA: 0x007D4687 File Offset: 0x007D2887
		// (set) Token: 0x0603A147 RID: 237895 RVA: 0x007D468F File Offset: 0x007D288F
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0B0 RID: 61616
		// (get) Token: 0x0603A148 RID: 237896 RVA: 0x007D4698 File Offset: 0x007D2898
		// (set) Token: 0x0603A149 RID: 237897 RVA: 0x007D46A0 File Offset: 0x007D28A0
		public float StartTime { get; set; }

		// Token: 0x1700F0B1 RID: 61617
		// (get) Token: 0x0603A14A RID: 237898 RVA: 0x007D46A9 File Offset: 0x007D28A9
		// (set) Token: 0x0603A14B RID: 237899 RVA: 0x007D46B1 File Offset: 0x007D28B1
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700F0B2 RID: 61618
		// (get) Token: 0x0603A14C RID: 237900 RVA: 0x007D46BA File Offset: 0x007D28BA
		// (set) Token: 0x0603A14D RID: 237901 RVA: 0x007D46C2 File Offset: 0x007D28C2
		public float FadeInTime { get; set; }

		// Token: 0x1700F0B3 RID: 61619
		// (get) Token: 0x0603A14E RID: 237902 RVA: 0x007D46CB File Offset: 0x007D28CB
		// (set) Token: 0x0603A14F RID: 237903 RVA: 0x007D46D3 File Offset: 0x007D28D3
		public EVisualNovelBlackScreenType ScreenType { get; set; }

		// Token: 0x1700F0B4 RID: 61620
		// (get) Token: 0x0603A150 RID: 237904 RVA: 0x007D46DC File Offset: 0x007D28DC
		// (set) Token: 0x0603A151 RID: 237905 RVA: 0x007D46E4 File Offset: 0x007D28E4
		public byte NullMask { get; set; }

		// Token: 0x0603A152 RID: 237906 RVA: 0x007D46ED File Offset: 0x007D28ED
		public IVisualNovelPerformanceEnterBlackScreenT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.EaseCurve = null;
			this.FadeInTime = 0f;
			this.ScreenType = EVisualNovelBlackScreenType.Black;
			this.NullMask = 0;
		}
	}
}
