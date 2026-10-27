using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047BB RID: 18363
	public class IEntityOwnerEntityT
	{
		// Token: 0x170083E9 RID: 33769
		// (get) Token: 0x0601C5AB RID: 116139 RVA: 0x0040363B File Offset: 0x0040183B
		// (set) Token: 0x0601C5AC RID: 116140 RVA: 0x00403643 File Offset: 0x00401843
		public EEntityOwnerType Type { get; set; }

		// Token: 0x170083EA RID: 33770
		// (get) Token: 0x0601C5AD RID: 116141 RVA: 0x0040364C File Offset: 0x0040184C
		// (set) Token: 0x0601C5AE RID: 116142 RVA: 0x00403654 File Offset: 0x00401854
		public int LevelId { get; set; }

		// Token: 0x170083EB RID: 33771
		// (get) Token: 0x0601C5AF RID: 116143 RVA: 0x0040365D File Offset: 0x0040185D
		// (set) Token: 0x0601C5B0 RID: 116144 RVA: 0x00403665 File Offset: 0x00401865
		public int EntityId { get; set; }

		// Token: 0x170083EC RID: 33772
		// (get) Token: 0x0601C5B1 RID: 116145 RVA: 0x0040366E File Offset: 0x0040186E
		// (set) Token: 0x0601C5B2 RID: 116146 RVA: 0x00403676 File Offset: 0x00401876
		public string FromFlowUid { get; set; }

		// Token: 0x0601C5B3 RID: 116147 RVA: 0x0040367F File Offset: 0x0040187F
		public IEntityOwnerEntityT()
		{
			this.Type = EEntityOwnerType.Quest;
			this.LevelId = 0;
			this.EntityId = 0;
			this.FromFlowUid = null;
		}
	}
}
