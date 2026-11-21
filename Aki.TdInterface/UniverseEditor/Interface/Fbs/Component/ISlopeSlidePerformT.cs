using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F46 RID: 24390
	public class ISlopeSlidePerformT
	{
		// Token: 0x1700B4A6 RID: 46246
		// (get) Token: 0x06028FD2 RID: 167890 RVA: 0x0059989E File Offset: 0x00597A9E
		// (set) Token: 0x06028FD3 RID: 167891 RVA: 0x005998A6 File Offset: 0x00597AA6
		public ESlidePerformType Type { get; set; }

		// Token: 0x1700B4A7 RID: 46247
		// (get) Token: 0x06028FD4 RID: 167892 RVA: 0x005998AF File Offset: 0x00597AAF
		// (set) Token: 0x06028FD5 RID: 167893 RVA: 0x005998B7 File Offset: 0x00597AB7
		public int TriggerLandingDistance { get; set; }

		// Token: 0x1700B4A8 RID: 46248
		// (get) Token: 0x06028FD6 RID: 167894 RVA: 0x005998C0 File Offset: 0x00597AC0
		// (set) Token: 0x06028FD7 RID: 167895 RVA: 0x005998C8 File Offset: 0x00597AC8
		public int FallbackLandingPointId { get; set; }

		// Token: 0x1700B4A9 RID: 46249
		// (get) Token: 0x06028FD8 RID: 167896 RVA: 0x005998D1 File Offset: 0x00597AD1
		// (set) Token: 0x06028FD9 RID: 167897 RVA: 0x005998D9 File Offset: 0x00597AD9
		public bool IsAllowJump { get; set; }

		// Token: 0x1700B4AA RID: 46250
		// (get) Token: 0x06028FDA RID: 167898 RVA: 0x005998E2 File Offset: 0x00597AE2
		// (set) Token: 0x06028FDB RID: 167899 RVA: 0x005998EA File Offset: 0x00597AEA
		public byte NullMask { get; set; }

		// Token: 0x06028FDC RID: 167900 RVA: 0x005998F3 File Offset: 0x00597AF3
		public ISlopeSlidePerformT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
			this.TriggerLandingDistance = 0;
			this.FallbackLandingPointId = 0;
			this.IsAllowJump = false;
			this.NullMask = 0;
		}
	}
}
