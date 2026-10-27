using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004095 RID: 16533
	public class IRecallEntryT
	{
		// Token: 0x170074AE RID: 29870
		// (get) Token: 0x0601811B RID: 98587 RVA: 0x0037894A File Offset: 0x00376B4A
		// (set) Token: 0x0601811C RID: 98588 RVA: 0x00378952 File Offset: 0x00376B52
		public int RecallId { get; set; }

		// Token: 0x170074AF RID: 29871
		// (get) Token: 0x0601811D RID: 98589 RVA: 0x0037895B File Offset: 0x00376B5B
		// (set) Token: 0x0601811E RID: 98590 RVA: 0x00378963 File Offset: 0x00376B63
		public List<int> IncludeGroups { get; set; }

		// Token: 0x170074B0 RID: 29872
		// (get) Token: 0x0601811F RID: 98591 RVA: 0x0037896C File Offset: 0x00376B6C
		// (set) Token: 0x06018120 RID: 98592 RVA: 0x00378974 File Offset: 0x00376B74
		public List<int> ExcludeGroups { get; set; }

		// Token: 0x06018121 RID: 98593 RVA: 0x0037897D File Offset: 0x00376B7D
		public IRecallEntryT()
		{
			this.RecallId = 0;
			this.IncludeGroups = null;
			this.ExcludeGroups = null;
		}
	}
}
