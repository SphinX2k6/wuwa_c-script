using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C51 RID: 31825
	public class ITrapDefensePlayerOperationConstructTrapT
	{
		// Token: 0x1700EE44 RID: 60996
		// (get) Token: 0x060395E9 RID: 234985 RVA: 0x007BEF52 File Offset: 0x007BD152
		// (set) Token: 0x060395EA RID: 234986 RVA: 0x007BEF5A File Offset: 0x007BD15A
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x060395EB RID: 234987 RVA: 0x007BEF63 File Offset: 0x007BD163
		public ITrapDefensePlayerOperationConstructTrapT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
