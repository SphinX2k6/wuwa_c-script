using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006475 RID: 25717
	public class ICommonBtPlaceholderT
	{
		// Token: 0x1700BF5D RID: 48989
		// (get) Token: 0x0602C8C1 RID: 182465 RVA: 0x0061DC15 File Offset: 0x0061BE15
		// (set) Token: 0x0602C8C2 RID: 182466 RVA: 0x0061DC1D File Offset: 0x0061BE1D
		public int Id { get; set; }

		// Token: 0x1700BF5E RID: 48990
		// (get) Token: 0x0602C8C3 RID: 182467 RVA: 0x0061DC26 File Offset: 0x0061BE26
		// (set) Token: 0x0602C8C4 RID: 182468 RVA: 0x0061DC2E File Offset: 0x0061BE2E
		public string Name { get; set; }

		// Token: 0x1700BF5F RID: 48991
		// (get) Token: 0x0602C8C5 RID: 182469 RVA: 0x0061DC37 File Offset: 0x0061BE37
		// (set) Token: 0x0602C8C6 RID: 182470 RVA: 0x0061DC3F File Offset: 0x0061BE3F
		public TCommonBtPlaceholderValueUnion Value { get; set; }

		// Token: 0x1700BF60 RID: 48992
		// (get) Token: 0x0602C8C7 RID: 182471 RVA: 0x0061DC48 File Offset: 0x0061BE48
		// (set) Token: 0x0602C8C8 RID: 182472 RVA: 0x0061DC50 File Offset: 0x0061BE50
		public List<int> RefTaskIds { get; set; }

		// Token: 0x0602C8C9 RID: 182473 RVA: 0x0061DC59 File Offset: 0x0061BE59
		public ICommonBtPlaceholderT()
		{
			this.Id = 0;
			this.Name = null;
			this.Value = null;
			this.RefTaskIds = null;
		}
	}
}
