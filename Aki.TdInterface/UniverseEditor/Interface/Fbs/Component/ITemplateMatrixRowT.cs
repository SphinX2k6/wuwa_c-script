using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006066 RID: 24678
	public class ITemplateMatrixRowT
	{
		// Token: 0x1700B748 RID: 46920
		// (get) Token: 0x06029B1C RID: 170780 RVA: 0x005B1659 File Offset: 0x005AF859
		// (set) Token: 0x06029B1D RID: 170781 RVA: 0x005B1661 File Offset: 0x005AF861
		public List<ISpawnTemplateEntityConfigT> Items { get; set; }

		// Token: 0x06029B1E RID: 170782 RVA: 0x005B166A File Offset: 0x005AF86A
		public ITemplateMatrixRowT()
		{
			this.Items = null;
		}
	}
}
