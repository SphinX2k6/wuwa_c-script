using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C20 RID: 19488
	public class IEntityOwnerDataT
	{
		// Token: 0x17008A22 RID: 35362
		// (get) Token: 0x0601DD62 RID: 122210 RVA: 0x0042F5B9 File Offset: 0x0042D7B9
		// (set) Token: 0x0601DD63 RID: 122211 RVA: 0x0042F5C1 File Offset: 0x0042D7C1
		public int LevelId { get; set; }

		// Token: 0x17008A23 RID: 35363
		// (get) Token: 0x0601DD64 RID: 122212 RVA: 0x0042F5CA File Offset: 0x0042D7CA
		// (set) Token: 0x0601DD65 RID: 122213 RVA: 0x0042F5D2 File Offset: 0x0042D7D2
		public int EntityId { get; set; }

		// Token: 0x17008A24 RID: 35364
		// (get) Token: 0x0601DD66 RID: 122214 RVA: 0x0042F5DB File Offset: 0x0042D7DB
		// (set) Token: 0x0601DD67 RID: 122215 RVA: 0x0042F5E3 File Offset: 0x0042D7E3
		public List<TEntityOwnerUnion> Owner { get; set; }

		// Token: 0x0601DD68 RID: 122216 RVA: 0x0042F5EC File Offset: 0x0042D7EC
		public IEntityOwnerDataT()
		{
			this.LevelId = 0;
			this.EntityId = 0;
			this.Owner = null;
		}
	}
}
