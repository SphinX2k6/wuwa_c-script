using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D8 RID: 25560
	public class IEaseCurveTypeT
	{
		// Token: 0x1700BCDE RID: 48350
		// (get) Token: 0x0602B6BA RID: 177850 RVA: 0x005EAB8E File Offset: 0x005E8D8E
		// (set) Token: 0x0602B6BB RID: 177851 RVA: 0x005EAB96 File Offset: 0x005E8D96
		public EEaseCurveType Type { get; set; }

		// Token: 0x0602B6BC RID: 177852 RVA: 0x005EAB9F File Offset: 0x005E8D9F
		public IEaseCurveTypeT()
		{
			this.Type = EEaseCurveType.Preset;
		}
	}
}
