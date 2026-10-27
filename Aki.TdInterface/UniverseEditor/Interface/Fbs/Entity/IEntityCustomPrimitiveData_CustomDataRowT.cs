using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A0 RID: 18336
	public class IEntityCustomPrimitiveData_CustomDataRowT
	{
		// Token: 0x17008390 RID: 33680
		// (get) Token: 0x0601C43F RID: 115775 RVA: 0x004005D5 File Offset: 0x003FE7D5
		// (set) Token: 0x0601C440 RID: 115776 RVA: 0x004005DD File Offset: 0x003FE7DD
		public List<float> Items { get; set; }

		// Token: 0x0601C441 RID: 115777 RVA: 0x004005E6 File Offset: 0x003FE7E6
		public IEntityCustomPrimitiveData_CustomDataRowT()
		{
			this.Items = null;
		}
	}
}
