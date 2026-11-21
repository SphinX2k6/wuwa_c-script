using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D3 RID: 17619
	public class IRecallEntityListT
	{
		// Token: 0x17007AAA RID: 31402
		// (get) Token: 0x0601978C RID: 104332 RVA: 0x003A22CF File Offset: 0x003A04CF
		// (set) Token: 0x0601978D RID: 104333 RVA: 0x003A22D7 File Offset: 0x003A04D7
		public int LevelId { get; set; }

		// Token: 0x17007AAB RID: 31403
		// (get) Token: 0x0601978E RID: 104334 RVA: 0x003A22E0 File Offset: 0x003A04E0
		// (set) Token: 0x0601978F RID: 104335 RVA: 0x003A22E8 File Offset: 0x003A04E8
		public List<int> EntityList { get; set; }

		// Token: 0x06019790 RID: 104336 RVA: 0x003A22F1 File Offset: 0x003A04F1
		public IRecallEntityListT()
		{
			this.LevelId = 0;
			this.EntityList = null;
		}
	}
}
