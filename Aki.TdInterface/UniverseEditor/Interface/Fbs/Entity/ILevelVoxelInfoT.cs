using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E8 RID: 18408
	public class ILevelVoxelInfoT
	{
		// Token: 0x1700844D RID: 33869
		// (get) Token: 0x0601C776 RID: 116598 RVA: 0x00406F93 File Offset: 0x00405193
		// (set) Token: 0x0601C777 RID: 116599 RVA: 0x00406F9B File Offset: 0x0040519B
		public int LevelId { get; set; }

		// Token: 0x1700844E RID: 33870
		// (get) Token: 0x0601C778 RID: 116600 RVA: 0x00406FA4 File Offset: 0x004051A4
		// (set) Token: 0x0601C779 RID: 116601 RVA: 0x00406FAC File Offset: 0x004051AC
		public List<IEntityVoxelInfoT> EntityVoxelInfos { get; set; }

		// Token: 0x0601C77A RID: 116602 RVA: 0x00406FB5 File Offset: 0x004051B5
		public ILevelVoxelInfoT()
		{
			this.LevelId = 0;
			this.EntityVoxelInfos = null;
		}
	}
}
