using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005957 RID: 22871
	public class ISpawnMonsterPointT
	{
		// Token: 0x1700ABB3 RID: 43955
		// (get) Token: 0x06026B75 RID: 158581 RVA: 0x00554DFB File Offset: 0x00552FFB
		// (set) Token: 0x06026B76 RID: 158582 RVA: 0x00554E03 File Offset: 0x00553003
		public EPointChooseType Type { get; set; }

		// Token: 0x1700ABB4 RID: 43956
		// (get) Token: 0x06026B77 RID: 158583 RVA: 0x00554E0C File Offset: 0x0055300C
		// (set) Token: 0x06026B78 RID: 158584 RVA: 0x00554E14 File Offset: 0x00553014
		public ISearchSpawnMonsterPointT RangeConstraint { get; set; }

		// Token: 0x06026B79 RID: 158585 RVA: 0x00554E1D File Offset: 0x0055301D
		public ISpawnMonsterPointT()
		{
			this.Type = EPointChooseType.SpawnMonsterPoint;
			this.RangeConstraint = null;
		}
	}
}
