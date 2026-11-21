using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C08 RID: 19464
	public class IEntityCustomPrimitiveData_CustomDataRowT
	{
		// Token: 0x170089D1 RID: 35281
		// (get) Token: 0x0601DC14 RID: 121876 RVA: 0x0042C871 File Offset: 0x0042AA71
		// (set) Token: 0x0601DC15 RID: 121877 RVA: 0x0042C879 File Offset: 0x0042AA79
		public List<float> Items { get; set; }

		// Token: 0x0601DC16 RID: 121878 RVA: 0x0042C882 File Offset: 0x0042AA82
		public IEntityCustomPrimitiveData_CustomDataRowT()
		{
			this.Items = null;
		}
	}
}
