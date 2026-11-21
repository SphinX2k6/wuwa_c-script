using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C4D RID: 19533
	public class ILevelCustomPrimitiveDataT
	{
		// Token: 0x17008A93 RID: 35475
		// (get) Token: 0x0601DF57 RID: 122711 RVA: 0x00433537 File Offset: 0x00431737
		// (set) Token: 0x0601DF58 RID: 122712 RVA: 0x0043353F File Offset: 0x0043173F
		public int LevelId { get; set; }

		// Token: 0x17008A94 RID: 35476
		// (get) Token: 0x0601DF59 RID: 122713 RVA: 0x00433548 File Offset: 0x00431748
		// (set) Token: 0x0601DF5A RID: 122714 RVA: 0x00433550 File Offset: 0x00431750
		public List<IEntityCustomPrimitiveDataT> Entities { get; set; }

		// Token: 0x0601DF5B RID: 122715 RVA: 0x00433559 File Offset: 0x00431759
		public ILevelCustomPrimitiveDataT()
		{
			this.LevelId = 0;
			this.Entities = null;
		}
	}
}
