using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006410 RID: 25616
	public class ICloseAirPassageMoveT
	{
		// Token: 0x1700BEC0 RID: 48832
		// (get) Token: 0x0602C533 RID: 181555 RVA: 0x006156AE File Offset: 0x006138AE
		// (set) Token: 0x0602C534 RID: 181556 RVA: 0x006156B6 File Offset: 0x006138B6
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BEC1 RID: 48833
		// (get) Token: 0x0602C535 RID: 181557 RVA: 0x006156BF File Offset: 0x006138BF
		// (set) Token: 0x0602C536 RID: 181558 RVA: 0x006156C7 File Offset: 0x006138C7
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BEC2 RID: 48834
		// (get) Token: 0x0602C537 RID: 181559 RVA: 0x006156D0 File Offset: 0x006138D0
		// (set) Token: 0x0602C538 RID: 181560 RVA: 0x006156D8 File Offset: 0x006138D8
		public byte NullMask { get; set; }

		// Token: 0x0602C539 RID: 181561 RVA: 0x006156E1 File Offset: 0x006138E1
		public ICloseAirPassageMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
