using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C17 RID: 19479
	public class IEntityListElementT
	{
		// Token: 0x17008A0D RID: 35341
		// (get) Token: 0x0601DCF2 RID: 122098 RVA: 0x0042E64B File Offset: 0x0042C84B
		// (set) Token: 0x0601DCF3 RID: 122099 RVA: 0x0042E653 File Offset: 0x0042C853
		public int ParentId { get; set; }

		// Token: 0x17008A0E RID: 35342
		// (get) Token: 0x0601DCF4 RID: 122100 RVA: 0x0042E65C File Offset: 0x0042C85C
		// (set) Token: 0x0601DCF5 RID: 122101 RVA: 0x0042E664 File Offset: 0x0042C864
		public IEntityDataT EntityData { get; set; }

		// Token: 0x0601DCF6 RID: 122102 RVA: 0x0042E66D File Offset: 0x0042C86D
		public IEntityListElementT()
		{
			this.ParentId = 0;
			this.EntityData = null;
		}
	}
}
