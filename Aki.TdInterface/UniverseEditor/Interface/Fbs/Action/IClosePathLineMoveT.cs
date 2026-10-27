using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006425 RID: 25637
	public class IClosePathLineMoveT
	{
		// Token: 0x1700BEE9 RID: 48873
		// (get) Token: 0x0602C5D9 RID: 181721 RVA: 0x00616716 File Offset: 0x00614916
		// (set) Token: 0x0602C5DA RID: 181722 RVA: 0x0061671E File Offset: 0x0061491E
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700BEEA RID: 48874
		// (get) Token: 0x0602C5DB RID: 181723 RVA: 0x00616727 File Offset: 0x00614927
		// (set) Token: 0x0602C5DC RID: 181724 RVA: 0x0061672F File Offset: 0x0061492F
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700BEEB RID: 48875
		// (get) Token: 0x0602C5DD RID: 181725 RVA: 0x00616738 File Offset: 0x00614938
		// (set) Token: 0x0602C5DE RID: 181726 RVA: 0x00616740 File Offset: 0x00614940
		public byte NullMask { get; set; }

		// Token: 0x0602C5DF RID: 181727 RVA: 0x00616749 File Offset: 0x00614949
		public IClosePathLineMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
