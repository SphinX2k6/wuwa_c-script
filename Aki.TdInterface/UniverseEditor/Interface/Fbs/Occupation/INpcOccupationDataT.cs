using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043AB RID: 17323
	public class INpcOccupationDataT
	{
		// Token: 0x17007A74 RID: 31348
		// (get) Token: 0x06019CB6 RID: 105654 RVA: 0x003B145A File Offset: 0x003AF65A
		// (set) Token: 0x06019CB7 RID: 105655 RVA: 0x003B1462 File Offset: 0x003AF662
		public EOccupationType Type { get; set; }

		// Token: 0x06019CB8 RID: 105656 RVA: 0x003B146B File Offset: 0x003AF66B
		public INpcOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
