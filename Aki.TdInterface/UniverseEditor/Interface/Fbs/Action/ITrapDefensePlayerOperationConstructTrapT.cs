using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745E RID: 29790
	public class ITrapDefensePlayerOperationConstructTrapT
	{
		// Token: 0x1700E227 RID: 57895
		// (get) Token: 0x06036200 RID: 221696 RVA: 0x0075C226 File Offset: 0x0075A426
		// (set) Token: 0x06036201 RID: 221697 RVA: 0x0075C22E File Offset: 0x0075A42E
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x06036202 RID: 221698 RVA: 0x0075C237 File Offset: 0x0075A437
		public ITrapDefensePlayerOperationConstructTrapT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
