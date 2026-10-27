using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D3 RID: 18387
	public class IEntityStateT
	{
		// Token: 0x1700841A RID: 33818
		// (get) Token: 0x0601C691 RID: 116369 RVA: 0x004051BF File Offset: 0x004033BF
		// (set) Token: 0x0601C692 RID: 116370 RVA: 0x004051C7 File Offset: 0x004033C7
		public int EntityId { get; set; }

		// Token: 0x1700841B RID: 33819
		// (get) Token: 0x0601C693 RID: 116371 RVA: 0x004051D0 File Offset: 0x004033D0
		// (set) Token: 0x0601C694 RID: 116372 RVA: 0x004051D8 File Offset: 0x004033D8
		public IEntityDataT Data { get; set; }

		// Token: 0x0601C695 RID: 116373 RVA: 0x004051E1 File Offset: 0x004033E1
		public IEntityStateT()
		{
			this.EntityId = 0;
			this.Data = null;
		}
	}
}
