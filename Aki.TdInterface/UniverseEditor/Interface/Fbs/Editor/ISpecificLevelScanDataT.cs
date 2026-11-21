using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D0D RID: 19725
	public class ISpecificLevelScanDataT
	{
		// Token: 0x17008D28 RID: 36136
		// (get) Token: 0x0601E87D RID: 125053 RVA: 0x0044639F File Offset: 0x0044459F
		// (set) Token: 0x0601E87E RID: 125054 RVA: 0x004463A7 File Offset: 0x004445A7
		public bool IsEnable { get; set; }

		// Token: 0x17008D29 RID: 36137
		// (get) Token: 0x0601E87F RID: 125055 RVA: 0x004463B0 File Offset: 0x004445B0
		// (set) Token: 0x0601E880 RID: 125056 RVA: 0x004463B8 File Offset: 0x004445B8
		public List<int> LevelIds { get; set; }

		// Token: 0x0601E881 RID: 125057 RVA: 0x004463C1 File Offset: 0x004445C1
		public ISpecificLevelScanDataT()
		{
			this.IsEnable = false;
			this.LevelIds = null;
		}
	}
}
