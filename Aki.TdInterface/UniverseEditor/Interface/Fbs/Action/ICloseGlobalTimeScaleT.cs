using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200641F RID: 25631
	public class ICloseGlobalTimeScaleT
	{
		// Token: 0x1700BEDB RID: 48859
		// (get) Token: 0x0602C5A5 RID: 181669 RVA: 0x006161DA File Offset: 0x006143DA
		// (set) Token: 0x0602C5A6 RID: 181670 RVA: 0x006161E2 File Offset: 0x006143E2
		public ESetTimeScaleType Type { get; set; }

		// Token: 0x1700BEDC RID: 48860
		// (get) Token: 0x0602C5A7 RID: 181671 RVA: 0x006161EB File Offset: 0x006143EB
		// (set) Token: 0x0602C5A8 RID: 181672 RVA: 0x006161F3 File Offset: 0x006143F3
		public ETimeScaleCloseSource TimeScaleCloseSource { get; set; }

		// Token: 0x1700BEDD RID: 48861
		// (get) Token: 0x0602C5A9 RID: 181673 RVA: 0x006161FC File Offset: 0x006143FC
		// (set) Token: 0x0602C5AA RID: 181674 RVA: 0x00616204 File Offset: 0x00614404
		public byte NullMask { get; set; }

		// Token: 0x0602C5AB RID: 181675 RVA: 0x0061620D File Offset: 0x0061440D
		public ICloseGlobalTimeScaleT()
		{
			this.Type = ESetTimeScaleType.Open;
			this.TimeScaleCloseSource = ETimeScaleCloseSource.All;
			this.NullMask = 0;
		}
	}
}
