using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BEA RID: 19434
	public class IChildEntityOwnerDataT
	{
		// Token: 0x17008990 RID: 35216
		// (get) Token: 0x0601DADE RID: 121566 RVA: 0x0042A2D1 File Offset: 0x004284D1
		// (set) Token: 0x0601DADF RID: 121567 RVA: 0x0042A2D9 File Offset: 0x004284D9
		public int LevelId { get; set; }

		// Token: 0x17008991 RID: 35217
		// (get) Token: 0x0601DAE0 RID: 121568 RVA: 0x0042A2E2 File Offset: 0x004284E2
		// (set) Token: 0x0601DAE1 RID: 121569 RVA: 0x0042A2EA File Offset: 0x004284EA
		public int EntityId { get; set; }

		// Token: 0x17008992 RID: 35218
		// (get) Token: 0x0601DAE2 RID: 121570 RVA: 0x0042A2F3 File Offset: 0x004284F3
		// (set) Token: 0x0601DAE3 RID: 121571 RVA: 0x0042A2FB File Offset: 0x004284FB
		public IEntityOwnerEntityT Owner { get; set; }

		// Token: 0x0601DAE4 RID: 121572 RVA: 0x0042A304 File Offset: 0x00428504
		public IChildEntityOwnerDataT()
		{
			this.LevelId = 0;
			this.EntityId = 0;
			this.Owner = null;
		}
	}
}
