using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005948 RID: 22856
	public class ISpawnMonsterCompleteConditionT
	{
		// Token: 0x1700AB8A RID: 43914
		// (get) Token: 0x06026AD0 RID: 158416 RVA: 0x005536FE File Offset: 0x005518FE
		// (set) Token: 0x06026AD1 RID: 158417 RVA: 0x00553706 File Offset: 0x00551906
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x06026AD2 RID: 158418 RVA: 0x0055370F File Offset: 0x0055190F
		public ISpawnMonsterCompleteConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
		}
	}
}
