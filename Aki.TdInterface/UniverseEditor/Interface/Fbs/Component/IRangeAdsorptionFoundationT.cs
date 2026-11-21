using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DFE RID: 24062
	public class IRangeAdsorptionFoundationT
	{
		// Token: 0x1700B159 RID: 45401
		// (get) Token: 0x060282B8 RID: 164536 RVA: 0x0057E71F File Offset: 0x0057C91F
		// (set) Token: 0x060282B9 RID: 164537 RVA: 0x0057E727 File Offset: 0x0057C927
		public EItemFoundation Type { get; set; }

		// Token: 0x1700B15A RID: 45402
		// (get) Token: 0x060282BA RID: 164538 RVA: 0x0057E730 File Offset: 0x0057C930
		// (set) Token: 0x060282BB RID: 164539 RVA: 0x0057E738 File Offset: 0x0057C938
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x1700B15B RID: 45403
		// (get) Token: 0x060282BC RID: 164540 RVA: 0x0057E741 File Offset: 0x0057C941
		// (set) Token: 0x060282BD RID: 164541 RVA: 0x0057E749 File Offset: 0x0057C949
		public IAdsorptionMatchingAnimationT Animation { get; set; }

		// Token: 0x1700B15C RID: 45404
		// (get) Token: 0x060282BE RID: 164542 RVA: 0x0057E752 File Offset: 0x0057C952
		// (set) Token: 0x060282BF RID: 164543 RVA: 0x0057E75A File Offset: 0x0057C95A
		public ICategoryMatchingAnimationT CategoryAnimation { get; set; }

		// Token: 0x1700B15D RID: 45405
		// (get) Token: 0x060282C0 RID: 164544 RVA: 0x0057E763 File Offset: 0x0057C963
		// (set) Token: 0x060282C1 RID: 164545 RVA: 0x0057E76B File Offset: 0x0057C96B
		public ICategoryMatchingSucceedT Callback { get; set; }

		// Token: 0x060282C2 RID: 164546 RVA: 0x0057E774 File Offset: 0x0057C974
		public IRangeAdsorptionFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
			this.Condition = null;
			this.Animation = null;
			this.CategoryAnimation = null;
			this.Callback = null;
		}
	}
}
