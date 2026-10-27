using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F5A RID: 16218
	public class INewHandInItemsProjectionMachineT
	{
		// Token: 0x170070C7 RID: 28871
		// (get) Token: 0x0601710A RID: 94474 RVA: 0x0035336E File Offset: 0x0035156E
		// (set) Token: 0x0601710B RID: 94475 RVA: 0x00353376 File Offset: 0x00351576
		public ENewHandInItemsType Type { get; set; }

		// Token: 0x170070C8 RID: 28872
		// (get) Token: 0x0601710C RID: 94476 RVA: 0x0035337F File Offset: 0x0035157F
		// (set) Token: 0x0601710D RID: 94477 RVA: 0x00353387 File Offset: 0x00351587
		public int EntityId { get; set; }

		// Token: 0x170070C9 RID: 28873
		// (get) Token: 0x0601710E RID: 94478 RVA: 0x00353390 File Offset: 0x00351590
		// (set) Token: 0x0601710F RID: 94479 RVA: 0x00353398 File Offset: 0x00351598
		public int ItemId { get; set; }

		// Token: 0x06017110 RID: 94480 RVA: 0x003533A1 File Offset: 0x003515A1
		public INewHandInItemsProjectionMachineT()
		{
			this.Type = ENewHandInItemsType.ProjectionMachine;
			this.EntityId = 0;
			this.ItemId = 0;
		}
	}
}
