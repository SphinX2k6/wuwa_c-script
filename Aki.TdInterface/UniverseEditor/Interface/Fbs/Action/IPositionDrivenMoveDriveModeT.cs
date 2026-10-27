using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D69 RID: 28009
	public class IPositionDrivenMoveDriveModeT
	{
		// Token: 0x1700D0EE RID: 53486
		// (get) Token: 0x0603176E RID: 202606 RVA: 0x006B4CD6 File Offset: 0x006B2ED6
		// (set) Token: 0x0603176F RID: 202607 RVA: 0x006B4CDE File Offset: 0x006B2EDE
		public ESplineMoveDriveMode Type { get; set; }

		// Token: 0x1700D0EF RID: 53487
		// (get) Token: 0x06031770 RID: 202608 RVA: 0x006B4CE7 File Offset: 0x006B2EE7
		// (set) Token: 0x06031771 RID: 202609 RVA: 0x006B4CEF File Offset: 0x006B2EEF
		public bool IsFixedPitch { get; set; }

		// Token: 0x1700D0F0 RID: 53488
		// (get) Token: 0x06031772 RID: 202610 RVA: 0x006B4CF8 File Offset: 0x006B2EF8
		// (set) Token: 0x06031773 RID: 202611 RVA: 0x006B4D00 File Offset: 0x006B2F00
		public byte NullMask { get; set; }

		// Token: 0x06031774 RID: 202612 RVA: 0x006B4D09 File Offset: 0x006B2F09
		public IPositionDrivenMoveDriveModeT()
		{
			this.Type = ESplineMoveDriveMode.InputDriven;
			this.IsFixedPitch = false;
			this.NullMask = 0;
		}
	}
}
