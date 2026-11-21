using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D2 RID: 25554
	public class IEaseCurveCustomT
	{
		// Token: 0x1700BCD5 RID: 48341
		// (get) Token: 0x0602B690 RID: 177808 RVA: 0x005EA7F3 File Offset: 0x005E89F3
		// (set) Token: 0x0602B691 RID: 177809 RVA: 0x005EA7FB File Offset: 0x005E89FB
		public EEaseCurveType Type { get; set; }

		// Token: 0x1700BCD6 RID: 48342
		// (get) Token: 0x0602B692 RID: 177810 RVA: 0x005EA804 File Offset: 0x005E8A04
		// (set) Token: 0x0602B693 RID: 177811 RVA: 0x005EA80C File Offset: 0x005E8A0C
		public string CustomCurve { get; set; }

		// Token: 0x0602B694 RID: 177812 RVA: 0x005EA815 File Offset: 0x005E8A15
		public IEaseCurveCustomT()
		{
			this.Type = EEaseCurveType.Preset;
			this.CustomCurve = null;
		}
	}
}
