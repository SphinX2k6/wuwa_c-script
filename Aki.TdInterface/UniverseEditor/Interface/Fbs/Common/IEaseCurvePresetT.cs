using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D98 RID: 23960
	public class IEaseCurvePresetT
	{
		// Token: 0x1700B374 RID: 45940
		// (get) Token: 0x0602901C RID: 167964 RVA: 0x005A1CC0 File Offset: 0x0059FEC0
		// (set) Token: 0x0602901D RID: 167965 RVA: 0x005A1CC8 File Offset: 0x0059FEC8
		public EEaseCurveType Type { get; set; }

		// Token: 0x1700B375 RID: 45941
		// (get) Token: 0x0602901E RID: 167966 RVA: 0x005A1CD1 File Offset: 0x0059FED1
		// (set) Token: 0x0602901F RID: 167967 RVA: 0x005A1CD9 File Offset: 0x0059FED9
		public EPresetEaseType PresetType { get; set; }

		// Token: 0x06029020 RID: 167968 RVA: 0x005A1CE2 File Offset: 0x0059FEE2
		public IEaseCurvePresetT()
		{
			this.Type = EEaseCurveType.Preset;
			this.PresetType = EPresetEaseType.Linear;
		}
	}
}
