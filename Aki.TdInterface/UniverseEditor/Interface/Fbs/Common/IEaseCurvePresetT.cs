using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D5 RID: 25557
	public class IEaseCurvePresetT
	{
		// Token: 0x1700BCDA RID: 48346
		// (get) Token: 0x0602B6A6 RID: 177830 RVA: 0x005EA9F0 File Offset: 0x005E8BF0
		// (set) Token: 0x0602B6A7 RID: 177831 RVA: 0x005EA9F8 File Offset: 0x005E8BF8
		public EEaseCurveType Type { get; set; }

		// Token: 0x1700BCDB RID: 48347
		// (get) Token: 0x0602B6A8 RID: 177832 RVA: 0x005EAA01 File Offset: 0x005E8C01
		// (set) Token: 0x0602B6A9 RID: 177833 RVA: 0x005EAA09 File Offset: 0x005E8C09
		public EPresetEaseType PresetType { get; set; }

		// Token: 0x0602B6AA RID: 177834 RVA: 0x005EAA12 File Offset: 0x005E8C12
		public IEaseCurvePresetT()
		{
			this.Type = EEaseCurveType.Preset;
			this.PresetType = EPresetEaseType.Linear;
		}
	}
}
