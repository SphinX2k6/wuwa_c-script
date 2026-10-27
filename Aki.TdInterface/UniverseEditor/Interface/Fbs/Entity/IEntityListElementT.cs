using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047AF RID: 18351
	public class IEntityListElementT
	{
		// Token: 0x170083CC RID: 33740
		// (get) Token: 0x0601C51D RID: 115997 RVA: 0x004023AF File Offset: 0x004005AF
		// (set) Token: 0x0601C51E RID: 115998 RVA: 0x004023B7 File Offset: 0x004005B7
		public int ParentId { get; set; }

		// Token: 0x170083CD RID: 33741
		// (get) Token: 0x0601C51F RID: 115999 RVA: 0x004023C0 File Offset: 0x004005C0
		// (set) Token: 0x0601C520 RID: 116000 RVA: 0x004023C8 File Offset: 0x004005C8
		public IEntityDataT EntityData { get; set; }

		// Token: 0x0601C521 RID: 116001 RVA: 0x004023D1 File Offset: 0x004005D1
		public IEntityListElementT()
		{
			this.ParentId = 0;
			this.EntityData = null;
		}
	}
}
