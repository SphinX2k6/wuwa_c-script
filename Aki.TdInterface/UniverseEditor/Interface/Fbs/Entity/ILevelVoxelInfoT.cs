using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C50 RID: 19536
	public class ILevelVoxelInfoT
	{
		// Token: 0x17008A98 RID: 35480
		// (get) Token: 0x0601DF73 RID: 122739 RVA: 0x004338E3 File Offset: 0x00431AE3
		// (set) Token: 0x0601DF74 RID: 122740 RVA: 0x004338EB File Offset: 0x00431AEB
		public int LevelId { get; set; }

		// Token: 0x17008A99 RID: 35481
		// (get) Token: 0x0601DF75 RID: 122741 RVA: 0x004338F4 File Offset: 0x00431AF4
		// (set) Token: 0x0601DF76 RID: 122742 RVA: 0x004338FC File Offset: 0x00431AFC
		public List<IEntityVoxelInfoT> EntityVoxelInfos { get; set; }

		// Token: 0x0601DF77 RID: 122743 RVA: 0x00433905 File Offset: 0x00431B05
		public ILevelVoxelInfoT()
		{
			this.LevelId = 0;
			this.EntityVoxelInfos = null;
		}
	}
}
