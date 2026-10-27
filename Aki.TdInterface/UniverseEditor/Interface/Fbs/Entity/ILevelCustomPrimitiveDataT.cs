using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E5 RID: 18405
	public class ILevelCustomPrimitiveDataT
	{
		// Token: 0x17008448 RID: 33864
		// (get) Token: 0x0601C75A RID: 116570 RVA: 0x00406BE7 File Offset: 0x00404DE7
		// (set) Token: 0x0601C75B RID: 116571 RVA: 0x00406BEF File Offset: 0x00404DEF
		public int LevelId { get; set; }

		// Token: 0x17008449 RID: 33865
		// (get) Token: 0x0601C75C RID: 116572 RVA: 0x00406BF8 File Offset: 0x00404DF8
		// (set) Token: 0x0601C75D RID: 116573 RVA: 0x00406C00 File Offset: 0x00404E00
		public List<IEntityCustomPrimitiveDataT> Entities { get; set; }

		// Token: 0x0601C75E RID: 116574 RVA: 0x00406C09 File Offset: 0x00404E09
		public ILevelCustomPrimitiveDataT()
		{
			this.LevelId = 0;
			this.Entities = null;
		}
	}
}
