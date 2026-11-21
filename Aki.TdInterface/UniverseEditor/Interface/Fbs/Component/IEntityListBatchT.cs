using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EF RID: 22255
	public class IEntityListBatchT
	{
		// Token: 0x1700A06F RID: 41071
		// (get) Token: 0x06023B75 RID: 146293 RVA: 0x004E908F File Offset: 0x004E728F
		// (set) Token: 0x06023B76 RID: 146294 RVA: 0x004E9097 File Offset: 0x004E7297
		public EEntityBatchType Type { get; set; }

		// Token: 0x1700A070 RID: 41072
		// (get) Token: 0x06023B77 RID: 146295 RVA: 0x004E90A0 File Offset: 0x004E72A0
		// (set) Token: 0x06023B78 RID: 146296 RVA: 0x004E90A8 File Offset: 0x004E72A8
		public List<int> EntityIds { get; set; }

		// Token: 0x06023B79 RID: 146297 RVA: 0x004E90B1 File Offset: 0x004E72B1
		public IEntityListBatchT()
		{
			this.Type = EEntityBatchType.EntityList;
			this.EntityIds = null;
		}
	}
}
