using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D6 RID: 17622
	public class IRecallEntryT
	{
		// Token: 0x17007AB0 RID: 31408
		// (get) Token: 0x060197B4 RID: 104372 RVA: 0x003A2782 File Offset: 0x003A0982
		// (set) Token: 0x060197B5 RID: 104373 RVA: 0x003A278A File Offset: 0x003A098A
		public int RecallId { get; set; }

		// Token: 0x17007AB1 RID: 31409
		// (get) Token: 0x060197B6 RID: 104374 RVA: 0x003A2793 File Offset: 0x003A0993
		// (set) Token: 0x060197B7 RID: 104375 RVA: 0x003A279B File Offset: 0x003A099B
		public List<int> IncludeGroups { get; set; }

		// Token: 0x17007AB2 RID: 31410
		// (get) Token: 0x060197B8 RID: 104376 RVA: 0x003A27A4 File Offset: 0x003A09A4
		// (set) Token: 0x060197B9 RID: 104377 RVA: 0x003A27AC File Offset: 0x003A09AC
		public List<int> ExcludeGroups { get; set; }

		// Token: 0x060197BA RID: 104378 RVA: 0x003A27B5 File Offset: 0x003A09B5
		public IRecallEntryT()
		{
			this.RecallId = 0;
			this.IncludeGroups = null;
			this.ExcludeGroups = null;
		}
	}
}
