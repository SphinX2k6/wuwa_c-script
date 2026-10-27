using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007467 RID: 29799
	public class ITrapDefensePlayerOperationTypeT
	{
		// Token: 0x1700E230 RID: 57904
		// (get) Token: 0x06036236 RID: 221750 RVA: 0x0075C68E File Offset: 0x0075A88E
		// (set) Token: 0x06036237 RID: 221751 RVA: 0x0075C696 File Offset: 0x0075A896
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x06036238 RID: 221752 RVA: 0x0075C69F File Offset: 0x0075A89F
		public ITrapDefensePlayerOperationTypeT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
