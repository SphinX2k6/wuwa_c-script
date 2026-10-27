using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C4 RID: 18372
	public class IEntityOwnerLevelPlayT
	{
		// Token: 0x170083F5 RID: 33781
		// (get) Token: 0x0601C5E7 RID: 116199 RVA: 0x00403B94 File Offset: 0x00401D94
		// (set) Token: 0x0601C5E8 RID: 116200 RVA: 0x00403B9C File Offset: 0x00401D9C
		public EEntityOwnerType Type { get; set; }

		// Token: 0x170083F6 RID: 33782
		// (get) Token: 0x0601C5E9 RID: 116201 RVA: 0x00403BA5 File Offset: 0x00401DA5
		// (set) Token: 0x0601C5EA RID: 116202 RVA: 0x00403BAD File Offset: 0x00401DAD
		public int LevelPlayId { get; set; }

		// Token: 0x0601C5EB RID: 116203 RVA: 0x00403BB6 File Offset: 0x00401DB6
		public IEntityOwnerLevelPlayT()
		{
			this.Type = EEntityOwnerType.Quest;
			this.LevelPlayId = 0;
		}
	}
}
