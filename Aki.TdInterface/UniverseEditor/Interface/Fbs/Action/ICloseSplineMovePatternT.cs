using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200643A RID: 25658
	public class ICloseSplineMovePatternT
	{
		// Token: 0x1700BF10 RID: 48912
		// (get) Token: 0x0602C68E RID: 181902 RVA: 0x00617D7A File Offset: 0x00615F7A
		// (set) Token: 0x0602C68F RID: 181903 RVA: 0x00617D82 File Offset: 0x00615F82
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BF11 RID: 48913
		// (get) Token: 0x0602C690 RID: 181904 RVA: 0x00617D8B File Offset: 0x00615F8B
		// (set) Token: 0x0602C691 RID: 181905 RVA: 0x00617D93 File Offset: 0x00615F93
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BF12 RID: 48914
		// (get) Token: 0x0602C692 RID: 181906 RVA: 0x00617D9C File Offset: 0x00615F9C
		// (set) Token: 0x0602C693 RID: 181907 RVA: 0x00617DA4 File Offset: 0x00615FA4
		public byte NullMask { get; set; }

		// Token: 0x0602C694 RID: 181908 RVA: 0x00617DAD File Offset: 0x00615FAD
		public ICloseSplineMovePatternT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
