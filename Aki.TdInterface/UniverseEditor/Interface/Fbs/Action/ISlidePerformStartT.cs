using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007143 RID: 28995
	public class ISlidePerformStartT
	{
		// Token: 0x1700D773 RID: 55155
		// (get) Token: 0x06033676 RID: 210550 RVA: 0x006ED573 File Offset: 0x006EB773
		// (set) Token: 0x06033677 RID: 210551 RVA: 0x006ED57B File Offset: 0x006EB77B
		public int SlideEntityId { get; set; }

		// Token: 0x1700D774 RID: 55156
		// (get) Token: 0x06033678 RID: 210552 RVA: 0x006ED584 File Offset: 0x006EB784
		// (set) Token: 0x06033679 RID: 210553 RVA: 0x006ED58C File Offset: 0x006EB78C
		public ISlopeSlidePerformStartT SlidePerformConfig { get; set; }

		// Token: 0x0603367A RID: 210554 RVA: 0x006ED595 File Offset: 0x006EB795
		public ISlidePerformStartT()
		{
			this.SlideEntityId = 0;
			this.SlidePerformConfig = null;
		}
	}
}
