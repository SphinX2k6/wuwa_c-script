using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A8 RID: 18600
	public class ISpecificLevelScanDataT
	{
		// Token: 0x170086E0 RID: 34528
		// (get) Token: 0x0601D090 RID: 118928 RVA: 0x00419C03 File Offset: 0x00417E03
		// (set) Token: 0x0601D091 RID: 118929 RVA: 0x00419C0B File Offset: 0x00417E0B
		public bool IsEnable { get; set; }

		// Token: 0x170086E1 RID: 34529
		// (get) Token: 0x0601D092 RID: 118930 RVA: 0x00419C14 File Offset: 0x00417E14
		// (set) Token: 0x0601D093 RID: 118931 RVA: 0x00419C1C File Offset: 0x00417E1C
		public List<int> LevelIds { get; set; }

		// Token: 0x0601D094 RID: 118932 RVA: 0x00419C25 File Offset: 0x00417E25
		public ISpecificLevelScanDataT()
		{
			this.IsEnable = false;
			this.LevelIds = null;
		}
	}
}
