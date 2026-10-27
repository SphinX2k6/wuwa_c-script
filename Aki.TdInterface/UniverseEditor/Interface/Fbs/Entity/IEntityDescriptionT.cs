using System;
using Aki.UniverseEditor.Interface.Fbs.Editor;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A9 RID: 18345
	public class IEntityDescriptionT
	{
		// Token: 0x170083C0 RID: 33728
		// (get) Token: 0x0601C4E7 RID: 115943 RVA: 0x00401D4C File Offset: 0x003FFF4C
		// (set) Token: 0x0601C4E8 RID: 115944 RVA: 0x00401D54 File Offset: 0x003FFF54
		public string Category { get; set; }

		// Token: 0x170083C1 RID: 33729
		// (get) Token: 0x0601C4E9 RID: 115945 RVA: 0x00401D5D File Offset: 0x003FFF5D
		// (set) Token: 0x0601C4EA RID: 115946 RVA: 0x00401D65 File Offset: 0x003FFF65
		public ETdDeveloper Owner { get; set; }

		// Token: 0x170083C2 RID: 33730
		// (get) Token: 0x0601C4EB RID: 115947 RVA: 0x00401D6E File Offset: 0x003FFF6E
		// (set) Token: 0x0601C4EC RID: 115948 RVA: 0x00401D76 File Offset: 0x003FFF76
		public string Status { get; set; }

		// Token: 0x170083C3 RID: 33731
		// (get) Token: 0x0601C4ED RID: 115949 RVA: 0x00401D7F File Offset: 0x003FFF7F
		// (set) Token: 0x0601C4EE RID: 115950 RVA: 0x00401D87 File Offset: 0x003FFF87
		public string Description { get; set; }

		// Token: 0x0601C4EF RID: 115951 RVA: 0x00401D90 File Offset: 0x003FFF90
		public IEntityDescriptionT()
		{
			this.Category = null;
			this.Owner = ETdDeveloper.None;
			this.Status = null;
			this.Description = null;
		}
	}
}
