using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F3 RID: 23027
	public class ISunSpiritBlockExtraRangeT
	{
		// Token: 0x1700AD01 RID: 44289
		// (get) Token: 0x0602713E RID: 160062 RVA: 0x00560567 File Offset: 0x0055E767
		// (set) Token: 0x0602713F RID: 160063 RVA: 0x0056056F File Offset: 0x0055E76F
		public EExtraRangeType Type { get; set; }

		// Token: 0x1700AD02 RID: 44290
		// (get) Token: 0x06027140 RID: 160064 RVA: 0x00560578 File Offset: 0x0055E778
		// (set) Token: 0x06027141 RID: 160065 RVA: 0x00560580 File Offset: 0x0055E780
		public ICylinderTriggerShapeT CylinderRange { get; set; }

		// Token: 0x06027142 RID: 160066 RVA: 0x00560589 File Offset: 0x0055E789
		public ISunSpiritBlockExtraRangeT()
		{
			this.Type = EExtraRangeType.SunSpiritBlock;
			this.CylinderRange = null;
		}
	}
}
