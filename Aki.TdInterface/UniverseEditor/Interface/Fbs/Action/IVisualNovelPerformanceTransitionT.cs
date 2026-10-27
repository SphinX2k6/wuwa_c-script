using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C9 RID: 30153
	public class IVisualNovelPerformanceTransitionT
	{
		// Token: 0x1700E505 RID: 58629
		// (get) Token: 0x06036EB0 RID: 224944 RVA: 0x007744DF File Offset: 0x007726DF
		// (set) Token: 0x06036EB1 RID: 224945 RVA: 0x007744E7 File Offset: 0x007726E7
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E506 RID: 58630
		// (get) Token: 0x06036EB2 RID: 224946 RVA: 0x007744F0 File Offset: 0x007726F0
		// (set) Token: 0x06036EB3 RID: 224947 RVA: 0x007744F8 File Offset: 0x007726F8
		public float StartTime { get; set; }

		// Token: 0x1700E507 RID: 58631
		// (get) Token: 0x06036EB4 RID: 224948 RVA: 0x00774501 File Offset: 0x00772701
		// (set) Token: 0x06036EB5 RID: 224949 RVA: 0x00774509 File Offset: 0x00772709
		public IVisualNovelTransitionPerformanceSolarSchoolT TransitionPerformanceConfig { get; set; }

		// Token: 0x1700E508 RID: 58632
		// (get) Token: 0x06036EB6 RID: 224950 RVA: 0x00774512 File Offset: 0x00772712
		// (set) Token: 0x06036EB7 RID: 224951 RVA: 0x0077451A File Offset: 0x0077271A
		public byte NullMask { get; set; }

		// Token: 0x06036EB8 RID: 224952 RVA: 0x00774523 File Offset: 0x00772723
		public IVisualNovelPerformanceTransitionT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.TransitionPerformanceConfig = null;
			this.NullMask = 0;
		}
	}
}
