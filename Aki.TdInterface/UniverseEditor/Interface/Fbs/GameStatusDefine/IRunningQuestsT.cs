using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B72 RID: 19314
	public class IRunningQuestsT
	{
		// Token: 0x17008872 RID: 34930
		// (get) Token: 0x0601D626 RID: 120358 RVA: 0x0042054E File Offset: 0x0041E74E
		// (set) Token: 0x0601D627 RID: 120359 RVA: 0x00420556 File Offset: 0x0041E756
		public int TraceId { get; set; }

		// Token: 0x17008873 RID: 34931
		// (get) Token: 0x0601D628 RID: 120360 RVA: 0x0042055F File Offset: 0x0041E75F
		// (set) Token: 0x0601D629 RID: 120361 RVA: 0x00420567 File Offset: 0x0041E767
		public IRunningTreeT TraceTree { get; set; }

		// Token: 0x17008874 RID: 34932
		// (get) Token: 0x0601D62A RID: 120362 RVA: 0x00420570 File Offset: 0x0041E770
		// (set) Token: 0x0601D62B RID: 120363 RVA: 0x00420578 File Offset: 0x0041E778
		public List<IRunningTreeT> Quests { get; set; }

		// Token: 0x0601D62C RID: 120364 RVA: 0x00420581 File Offset: 0x0041E781
		public IRunningQuestsT()
		{
			this.TraceId = 0;
			this.TraceTree = null;
			this.Quests = null;
		}
	}
}
