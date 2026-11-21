using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C47 RID: 19527
	public class IEntityVoxelInfoT
	{
		// Token: 0x17008A89 RID: 35465
		// (get) Token: 0x0601DF25 RID: 122661 RVA: 0x00432F8B File Offset: 0x0043118B
		// (set) Token: 0x0601DF26 RID: 122662 RVA: 0x00432F93 File Offset: 0x00431193
		public int EntityId { get; set; }

		// Token: 0x17008A8A RID: 35466
		// (get) Token: 0x0601DF27 RID: 122663 RVA: 0x00432F9C File Offset: 0x0043119C
		// (set) Token: 0x0601DF28 RID: 122664 RVA: 0x00432FA4 File Offset: 0x004311A4
		public IVoxelInfoT VoxelInfo { get; set; }

		// Token: 0x0601DF29 RID: 122665 RVA: 0x00432FAD File Offset: 0x004311AD
		public IEntityVoxelInfoT()
		{
			this.EntityId = 0;
			this.VoxelInfo = null;
		}
	}
}
