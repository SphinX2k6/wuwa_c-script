using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200400B RID: 16395
	public class IQuestRecallConfigT
	{
		// Token: 0x17007334 RID: 29492
		// (get) Token: 0x06017A98 RID: 96920 RVA: 0x00369C4B File Offset: 0x00367E4B
		// (set) Token: 0x06017A99 RID: 96921 RVA: 0x00369C53 File Offset: 0x00367E53
		public int RecallId { get; set; }

		// Token: 0x17007335 RID: 29493
		// (get) Token: 0x06017A9A RID: 96922 RVA: 0x00369C5C File Offset: 0x00367E5C
		// (set) Token: 0x06017A9B RID: 96923 RVA: 0x00369C64 File Offset: 0x00367E64
		public List<IRecallEntityListT> RecallEntityList { get; set; }

		// Token: 0x06017A9C RID: 96924 RVA: 0x00369C6D File Offset: 0x00367E6D
		public IQuestRecallConfigT()
		{
			this.RecallId = 0;
			this.RecallEntityList = null;
		}
	}
}
