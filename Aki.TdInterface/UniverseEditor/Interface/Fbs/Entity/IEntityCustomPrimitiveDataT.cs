using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200479D RID: 18333
	public class IEntityCustomPrimitiveDataT
	{
		// Token: 0x1700838C RID: 33676
		// (get) Token: 0x0601C423 RID: 115747 RVA: 0x004002E3 File Offset: 0x003FE4E3
		// (set) Token: 0x0601C424 RID: 115748 RVA: 0x004002EB File Offset: 0x003FE4EB
		public int Id { get; set; }

		// Token: 0x1700838D RID: 33677
		// (get) Token: 0x0601C425 RID: 115749 RVA: 0x004002F4 File Offset: 0x003FE4F4
		// (set) Token: 0x0601C426 RID: 115750 RVA: 0x004002FC File Offset: 0x003FE4FC
		public List<IEntityCustomPrimitiveData_CustomDataRowT> CustomData { get; set; }

		// Token: 0x0601C427 RID: 115751 RVA: 0x00400305 File Offset: 0x003FE505
		public IEntityCustomPrimitiveDataT()
		{
			this.Id = 0;
			this.CustomData = null;
		}
	}
}
