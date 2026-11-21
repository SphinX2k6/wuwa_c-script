using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D0 RID: 17616
	public class IRecallEntityGroupT
	{
		// Token: 0x17007AA3 RID: 31395
		// (get) Token: 0x0601976A RID: 104298 RVA: 0x003A1F4C File Offset: 0x003A014C
		// (set) Token: 0x0601976B RID: 104299 RVA: 0x003A1F54 File Offset: 0x003A0154
		public int Index { get; set; }

		// Token: 0x17007AA4 RID: 31396
		// (get) Token: 0x0601976C RID: 104300 RVA: 0x003A1F5D File Offset: 0x003A015D
		// (set) Token: 0x0601976D RID: 104301 RVA: 0x003A1F65 File Offset: 0x003A0165
		public string Source { get; set; }

		// Token: 0x17007AA5 RID: 31397
		// (get) Token: 0x0601976E RID: 104302 RVA: 0x003A1F6E File Offset: 0x003A016E
		// (set) Token: 0x0601976F RID: 104303 RVA: 0x003A1F76 File Offset: 0x003A0176
		public int LevelId { get; set; }

		// Token: 0x17007AA6 RID: 31398
		// (get) Token: 0x06019770 RID: 104304 RVA: 0x003A1F7F File Offset: 0x003A017F
		// (set) Token: 0x06019771 RID: 104305 RVA: 0x003A1F87 File Offset: 0x003A0187
		public List<int> Entities { get; set; }

		// Token: 0x06019772 RID: 104306 RVA: 0x003A1F90 File Offset: 0x003A0190
		public IRecallEntityGroupT()
		{
			this.Index = 0;
			this.Source = null;
			this.LevelId = 0;
			this.Entities = null;
		}
	}
}
