using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047DF RID: 18399
	public class IEntityVoxelInfoT
	{
		// Token: 0x1700843E RID: 33854
		// (get) Token: 0x0601C728 RID: 116520 RVA: 0x0040663B File Offset: 0x0040483B
		// (set) Token: 0x0601C729 RID: 116521 RVA: 0x00406643 File Offset: 0x00404843
		public int EntityId { get; set; }

		// Token: 0x1700843F RID: 33855
		// (get) Token: 0x0601C72A RID: 116522 RVA: 0x0040664C File Offset: 0x0040484C
		// (set) Token: 0x0601C72B RID: 116523 RVA: 0x00406654 File Offset: 0x00404854
		public IVoxelInfoT VoxelInfo { get; set; }

		// Token: 0x0601C72C RID: 116524 RVA: 0x0040665D File Offset: 0x0040485D
		public IEntityVoxelInfoT()
		{
			this.EntityId = 0;
			this.VoxelInfo = null;
		}
	}
}
