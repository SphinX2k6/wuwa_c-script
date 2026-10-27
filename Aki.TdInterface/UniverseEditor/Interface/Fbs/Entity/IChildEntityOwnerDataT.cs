using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004782 RID: 18306
	public class IChildEntityOwnerDataT
	{
		// Token: 0x1700834F RID: 33615
		// (get) Token: 0x0601C309 RID: 115465 RVA: 0x003FE035 File Offset: 0x003FC235
		// (set) Token: 0x0601C30A RID: 115466 RVA: 0x003FE03D File Offset: 0x003FC23D
		public int LevelId { get; set; }

		// Token: 0x17008350 RID: 33616
		// (get) Token: 0x0601C30B RID: 115467 RVA: 0x003FE046 File Offset: 0x003FC246
		// (set) Token: 0x0601C30C RID: 115468 RVA: 0x003FE04E File Offset: 0x003FC24E
		public int EntityId { get; set; }

		// Token: 0x17008351 RID: 33617
		// (get) Token: 0x0601C30D RID: 115469 RVA: 0x003FE057 File Offset: 0x003FC257
		// (set) Token: 0x0601C30E RID: 115470 RVA: 0x003FE05F File Offset: 0x003FC25F
		public IEntityOwnerEntityT Owner { get; set; }

		// Token: 0x0601C30F RID: 115471 RVA: 0x003FE068 File Offset: 0x003FC268
		public IChildEntityOwnerDataT()
		{
			this.LevelId = 0;
			this.EntityId = 0;
			this.Owner = null;
		}
	}
}
