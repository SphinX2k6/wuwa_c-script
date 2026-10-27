using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047AC RID: 18348
	public class IEntityListT
	{
		// Token: 0x170083C7 RID: 33735
		// (get) Token: 0x0601C507 RID: 115975 RVA: 0x00402123 File Offset: 0x00400323
		// (set) Token: 0x0601C508 RID: 115976 RVA: 0x0040212B File Offset: 0x0040032B
		public int EntityListId { get; set; }

		// Token: 0x170083C8 RID: 33736
		// (get) Token: 0x0601C509 RID: 115977 RVA: 0x00402134 File Offset: 0x00400334
		// (set) Token: 0x0601C50A RID: 115978 RVA: 0x0040213C File Offset: 0x0040033C
		public List<IEntityListElementT> Entities { get; set; }

		// Token: 0x0601C50B RID: 115979 RVA: 0x00402145 File Offset: 0x00400345
		public IEntityListT()
		{
			this.EntityListId = 0;
			this.Entities = null;
		}
	}
}
