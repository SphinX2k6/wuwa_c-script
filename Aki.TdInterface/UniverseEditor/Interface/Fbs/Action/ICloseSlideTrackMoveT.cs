using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA8 RID: 27304
	public class ICloseSlideTrackMoveT
	{
		// Token: 0x1700C88E RID: 51342
		// (get) Token: 0x0602EDD8 RID: 191960 RVA: 0x00662BF6 File Offset: 0x00660DF6
		// (set) Token: 0x0602EDD9 RID: 191961 RVA: 0x00662BFE File Offset: 0x00660DFE
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C88F RID: 51343
		// (get) Token: 0x0602EDDA RID: 191962 RVA: 0x00662C07 File Offset: 0x00660E07
		// (set) Token: 0x0602EDDB RID: 191963 RVA: 0x00662C0F File Offset: 0x00660E0F
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C890 RID: 51344
		// (get) Token: 0x0602EDDC RID: 191964 RVA: 0x00662C18 File Offset: 0x00660E18
		// (set) Token: 0x0602EDDD RID: 191965 RVA: 0x00662C20 File Offset: 0x00660E20
		public byte NullMask { get; set; }

		// Token: 0x0602EDDE RID: 191966 RVA: 0x00662C29 File Offset: 0x00660E29
		public ICloseSlideTrackMoveT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
