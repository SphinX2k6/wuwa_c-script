using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E2 RID: 18402
	public class IInstEntityDataT
	{
		// Token: 0x17008443 RID: 33859
		// (get) Token: 0x0601C73E RID: 116542 RVA: 0x0040685C File Offset: 0x00404A5C
		// (set) Token: 0x0601C73F RID: 116543 RVA: 0x00406864 File Offset: 0x00404A64
		public int InstId { get; set; }

		// Token: 0x17008444 RID: 33860
		// (get) Token: 0x0601C740 RID: 116544 RVA: 0x0040686D File Offset: 0x00404A6D
		// (set) Token: 0x0601C741 RID: 116545 RVA: 0x00406875 File Offset: 0x00404A75
		public int EntityConfigId { get; set; }

		// Token: 0x0601C742 RID: 116546 RVA: 0x0040687E File Offset: 0x00404A7E
		public IInstEntityDataT()
		{
			this.InstId = 0;
			this.EntityConfigId = 0;
		}
	}
}
