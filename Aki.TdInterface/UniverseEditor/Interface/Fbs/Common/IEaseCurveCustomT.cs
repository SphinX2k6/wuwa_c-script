using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D95 RID: 23957
	public class IEaseCurveCustomT
	{
		// Token: 0x1700B36F RID: 45935
		// (get) Token: 0x06029006 RID: 167942 RVA: 0x005A1AC3 File Offset: 0x0059FCC3
		// (set) Token: 0x06029007 RID: 167943 RVA: 0x005A1ACB File Offset: 0x0059FCCB
		public EEaseCurveType Type { get; set; }

		// Token: 0x1700B370 RID: 45936
		// (get) Token: 0x06029008 RID: 167944 RVA: 0x005A1AD4 File Offset: 0x0059FCD4
		// (set) Token: 0x06029009 RID: 167945 RVA: 0x005A1ADC File Offset: 0x0059FCDC
		public string CustomCurve { get; set; }

		// Token: 0x0602900A RID: 167946 RVA: 0x005A1AE5 File Offset: 0x0059FCE5
		public IEaseCurveCustomT()
		{
			this.Type = EEaseCurveType.Preset;
			this.CustomCurve = null;
		}
	}
}
