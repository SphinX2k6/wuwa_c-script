using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C05 RID: 19461
	public class IEntityCustomPrimitiveDataT
	{
		// Token: 0x170089CD RID: 35277
		// (get) Token: 0x0601DBF8 RID: 121848 RVA: 0x0042C57F File Offset: 0x0042A77F
		// (set) Token: 0x0601DBF9 RID: 121849 RVA: 0x0042C587 File Offset: 0x0042A787
		public int Id { get; set; }

		// Token: 0x170089CE RID: 35278
		// (get) Token: 0x0601DBFA RID: 121850 RVA: 0x0042C590 File Offset: 0x0042A790
		// (set) Token: 0x0601DBFB RID: 121851 RVA: 0x0042C598 File Offset: 0x0042A798
		public List<IEntityCustomPrimitiveData_CustomDataRowT> CustomData { get; set; }

		// Token: 0x0601DBFC RID: 121852 RVA: 0x0042C5A1 File Offset: 0x0042A7A1
		public IEntityCustomPrimitiveDataT()
		{
			this.Id = 0;
			this.CustomData = null;
		}
	}
}
