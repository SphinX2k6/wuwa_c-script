using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB4 RID: 27316
	public class ICloseTraceSplineT
	{
		// Token: 0x1700C8A4 RID: 51364
		// (get) Token: 0x0602EE3F RID: 192063 RVA: 0x00663804 File Offset: 0x00661A04
		// (set) Token: 0x0602EE40 RID: 192064 RVA: 0x0066380C File Offset: 0x00661A0C
		public ETraceSplineOptionType Type { get; set; }

		// Token: 0x1700C8A5 RID: 51365
		// (get) Token: 0x0602EE41 RID: 192065 RVA: 0x00663815 File Offset: 0x00661A15
		// (set) Token: 0x0602EE42 RID: 192066 RVA: 0x0066381D File Offset: 0x00661A1D
		public int SplineEntityId { get; set; }

		// Token: 0x0602EE43 RID: 192067 RVA: 0x00663826 File Offset: 0x00661A26
		public ICloseTraceSplineT()
		{
			this.Type = ETraceSplineOptionType.Open;
			this.SplineEntityId = 0;
		}
	}
}
