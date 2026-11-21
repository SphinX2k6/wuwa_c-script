using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EB RID: 22507
	public class IFlowerPollutionPointLightConfigT
	{
		// Token: 0x1700A2D9 RID: 41689
		// (get) Token: 0x0602461B RID: 149019 RVA: 0x004FFC84 File Offset: 0x004FDE84
		// (set) Token: 0x0602461C RID: 149020 RVA: 0x004FFC8C File Offset: 0x004FDE8C
		public List<int> PointLightEntityIds { get; set; }

		// Token: 0x1700A2DA RID: 41690
		// (get) Token: 0x0602461D RID: 149021 RVA: 0x004FFC95 File Offset: 0x004FDE95
		// (set) Token: 0x0602461E RID: 149022 RVA: 0x004FFC9D File Offset: 0x004FDE9D
		public List<IPointLightOperationsT> PointLightConfig { get; set; }

		// Token: 0x0602461F RID: 149023 RVA: 0x004FFCA6 File Offset: 0x004FDEA6
		public IFlowerPollutionPointLightConfigT()
		{
			this.PointLightEntityIds = null;
			this.PointLightConfig = null;
		}
	}
}
