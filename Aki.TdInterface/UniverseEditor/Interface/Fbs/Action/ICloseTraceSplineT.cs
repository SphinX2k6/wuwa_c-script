using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006440 RID: 25664
	public class ICloseTraceSplineT
	{
		// Token: 0x1700BF18 RID: 48920
		// (get) Token: 0x0602C6BA RID: 181946 RVA: 0x006181C0 File Offset: 0x006163C0
		// (set) Token: 0x0602C6BB RID: 181947 RVA: 0x006181C8 File Offset: 0x006163C8
		public ETraceSplineOptionType Type { get; set; }

		// Token: 0x1700BF19 RID: 48921
		// (get) Token: 0x0602C6BC RID: 181948 RVA: 0x006181D1 File Offset: 0x006163D1
		// (set) Token: 0x0602C6BD RID: 181949 RVA: 0x006181D9 File Offset: 0x006163D9
		public int SplineEntityId { get; set; }

		// Token: 0x0602C6BE RID: 181950 RVA: 0x006181E2 File Offset: 0x006163E2
		public ICloseTraceSplineT()
		{
			this.Type = ETraceSplineOptionType.Open;
			this.SplineEntityId = 0;
		}
	}
}
