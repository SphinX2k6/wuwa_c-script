using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E04 RID: 24068
	public class IGravityDirectionWorldAxisT
	{
		// Token: 0x1700B414 RID: 46100
		// (get) Token: 0x0602932C RID: 168748 RVA: 0x005A6DDC File Offset: 0x005A4FDC
		// (set) Token: 0x0602932D RID: 168749 RVA: 0x005A6DE4 File Offset: 0x005A4FE4
		public EGravityDirectionType Type { get; set; }

		// Token: 0x1700B415 RID: 46101
		// (get) Token: 0x0602932E RID: 168750 RVA: 0x005A6DED File Offset: 0x005A4FED
		// (set) Token: 0x0602932F RID: 168751 RVA: 0x005A6DF5 File Offset: 0x005A4FF5
		public EWorldAxisType WorldAxis { get; set; }

		// Token: 0x06029330 RID: 168752 RVA: 0x005A6DFE File Offset: 0x005A4FFE
		public IGravityDirectionWorldAxisT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
			this.WorldAxis = EWorldAxisType.PositiveX;
		}
	}
}
