using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007464 RID: 29796
	public class ITrapDefensePlayerOperationSpawnMonsterT
	{
		// Token: 0x1700E22D RID: 57901
		// (get) Token: 0x06036224 RID: 221732 RVA: 0x0075C516 File Offset: 0x0075A716
		// (set) Token: 0x06036225 RID: 221733 RVA: 0x0075C51E File Offset: 0x0075A71E
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x06036226 RID: 221734 RVA: 0x0075C527 File Offset: 0x0075A727
		public ITrapDefensePlayerOperationSpawnMonsterT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
