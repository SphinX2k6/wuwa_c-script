using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007461 RID: 29793
	public class ITrapDefensePlayerOperationRecycleTrapT
	{
		// Token: 0x1700E22A RID: 57898
		// (get) Token: 0x06036212 RID: 221714 RVA: 0x0075C39E File Offset: 0x0075A59E
		// (set) Token: 0x06036213 RID: 221715 RVA: 0x0075C3A6 File Offset: 0x0075A5A6
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x06036214 RID: 221716 RVA: 0x0075C3AF File Offset: 0x0075A5AF
		public ITrapDefensePlayerOperationRecycleTrapT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
