using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D0 RID: 18384
	public class IEntityPrefabElementT
	{
		// Token: 0x17008416 RID: 33814
		// (get) Token: 0x0601C67D RID: 116349 RVA: 0x00404F65 File Offset: 0x00403165
		// (set) Token: 0x0601C67E RID: 116350 RVA: 0x00404F6D File Offset: 0x0040316D
		public IEntityDataT EntityData { get; set; }

		// Token: 0x0601C67F RID: 116351 RVA: 0x00404F76 File Offset: 0x00403176
		public IEntityPrefabElementT()
		{
			this.EntityData = null;
		}
	}
}
