using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C57 RID: 31831
	public class ITrapDefensePlayerOperationSpawnMonsterT
	{
		// Token: 0x1700EE4A RID: 61002
		// (get) Token: 0x0603960D RID: 235021 RVA: 0x007BF242 File Offset: 0x007BD442
		// (set) Token: 0x0603960E RID: 235022 RVA: 0x007BF24A File Offset: 0x007BD44A
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x0603960F RID: 235023 RVA: 0x007BF253 File Offset: 0x007BD453
		public ITrapDefensePlayerOperationSpawnMonsterT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
