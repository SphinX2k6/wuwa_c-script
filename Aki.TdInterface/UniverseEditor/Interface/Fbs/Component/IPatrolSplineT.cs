using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005711 RID: 22289
	public class IPatrolSplineT
	{
		// Token: 0x1700A5F7 RID: 42487
		// (get) Token: 0x0602545F RID: 152671 RVA: 0x00524B51 File Offset: 0x00522D51
		// (set) Token: 0x06025460 RID: 152672 RVA: 0x00524B59 File Offset: 0x00522D59
		public ESplineType Type { get; set; }

		// Token: 0x1700A5F8 RID: 42488
		// (get) Token: 0x06025461 RID: 152673 RVA: 0x00524B62 File Offset: 0x00522D62
		// (set) Token: 0x06025462 RID: 152674 RVA: 0x00524B6A File Offset: 0x00522D6A
		public TPatrolCycleOptionUnion CycleOption { get; set; }

		// Token: 0x1700A5F9 RID: 42489
		// (get) Token: 0x06025463 RID: 152675 RVA: 0x00524B73 File Offset: 0x00522D73
		// (set) Token: 0x06025464 RID: 152676 RVA: 0x00524B7B File Offset: 0x00522D7B
		public bool IsNavigation { get; set; }

		// Token: 0x1700A5FA RID: 42490
		// (get) Token: 0x06025465 RID: 152677 RVA: 0x00524B84 File Offset: 0x00522D84
		// (set) Token: 0x06025466 RID: 152678 RVA: 0x00524B8C File Offset: 0x00522D8C
		public float TurnSpeed { get; set; }

		// Token: 0x1700A5FB RID: 42491
		// (get) Token: 0x06025467 RID: 152679 RVA: 0x00524B95 File Offset: 0x00522D95
		// (set) Token: 0x06025468 RID: 152680 RVA: 0x00524B9D File Offset: 0x00522D9D
		public bool IsFloating { get; set; }

		// Token: 0x1700A5FC RID: 42492
		// (get) Token: 0x06025469 RID: 152681 RVA: 0x00524BA6 File Offset: 0x00522DA6
		// (set) Token: 0x0602546A RID: 152682 RVA: 0x00524BAE File Offset: 0x00522DAE
		public List<IPatrolSplinePointT> Points { get; set; }

		// Token: 0x1700A5FD RID: 42493
		// (get) Token: 0x0602546B RID: 152683 RVA: 0x00524BB7 File Offset: 0x00522DB7
		// (set) Token: 0x0602546C RID: 152684 RVA: 0x00524BBF File Offset: 0x00522DBF
		public IPatrolRangeT PatrolRange { get; set; }

		// Token: 0x1700A5FE RID: 42494
		// (get) Token: 0x0602546D RID: 152685 RVA: 0x00524BC8 File Offset: 0x00522DC8
		// (set) Token: 0x0602546E RID: 152686 RVA: 0x00524BD0 File Offset: 0x00522DD0
		public byte NullMask { get; set; }

		// Token: 0x0602546F RID: 152687 RVA: 0x00524BDC File Offset: 0x00522DDC
		public IPatrolSplineT()
		{
			this.Type = ESplineType.Common;
			this.CycleOption = null;
			this.IsNavigation = false;
			this.TurnSpeed = 0f;
			this.IsFloating = false;
			this.Points = null;
			this.PatrolRange = null;
			this.NullMask = 0;
		}
	}
}
