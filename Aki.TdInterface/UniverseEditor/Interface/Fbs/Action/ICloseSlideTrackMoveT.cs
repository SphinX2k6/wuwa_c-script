using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006434 RID: 25652
	public class ICloseSlideTrackMoveT
	{
		// Token: 0x1700BF02 RID: 48898
		// (get) Token: 0x0602C653 RID: 181843 RVA: 0x006175B2 File Offset: 0x006157B2
		// (set) Token: 0x0602C654 RID: 181844 RVA: 0x006175BA File Offset: 0x006157BA
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BF03 RID: 48899
		// (get) Token: 0x0602C655 RID: 181845 RVA: 0x006175C3 File Offset: 0x006157C3
		// (set) Token: 0x0602C656 RID: 181846 RVA: 0x006175CB File Offset: 0x006157CB
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BF04 RID: 48900
		// (get) Token: 0x0602C657 RID: 181847 RVA: 0x006175D4 File Offset: 0x006157D4
		// (set) Token: 0x0602C658 RID: 181848 RVA: 0x006175DC File Offset: 0x006157DC
		public byte NullMask { get; set; }

		// Token: 0x0602C659 RID: 181849 RVA: 0x006175E5 File Offset: 0x006157E5
		public ICloseSlideTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
