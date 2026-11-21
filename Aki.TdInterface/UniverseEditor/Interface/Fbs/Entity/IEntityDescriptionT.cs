using System;
using Aki.UniverseEditor.Interface.Fbs.Editor;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C11 RID: 19473
	public class IEntityDescriptionT
	{
		// Token: 0x17008A01 RID: 35329
		// (get) Token: 0x0601DCBC RID: 122044 RVA: 0x0042DFE8 File Offset: 0x0042C1E8
		// (set) Token: 0x0601DCBD RID: 122045 RVA: 0x0042DFF0 File Offset: 0x0042C1F0
		public string Category { get; set; }

		// Token: 0x17008A02 RID: 35330
		// (get) Token: 0x0601DCBE RID: 122046 RVA: 0x0042DFF9 File Offset: 0x0042C1F9
		// (set) Token: 0x0601DCBF RID: 122047 RVA: 0x0042E001 File Offset: 0x0042C201
		public ETdDeveloper Owner { get; set; }

		// Token: 0x17008A03 RID: 35331
		// (get) Token: 0x0601DCC0 RID: 122048 RVA: 0x0042E00A File Offset: 0x0042C20A
		// (set) Token: 0x0601DCC1 RID: 122049 RVA: 0x0042E012 File Offset: 0x0042C212
		public string Status { get; set; }

		// Token: 0x17008A04 RID: 35332
		// (get) Token: 0x0601DCC2 RID: 122050 RVA: 0x0042E01B File Offset: 0x0042C21B
		// (set) Token: 0x0601DCC3 RID: 122051 RVA: 0x0042E023 File Offset: 0x0042C223
		public string Description { get; set; }

		// Token: 0x0601DCC4 RID: 122052 RVA: 0x0042E02C File Offset: 0x0042C22C
		public IEntityDescriptionT()
		{
			this.Category = null;
			this.Owner = ETdDeveloper.None;
			this.Status = null;
			this.Description = null;
		}
	}
}
