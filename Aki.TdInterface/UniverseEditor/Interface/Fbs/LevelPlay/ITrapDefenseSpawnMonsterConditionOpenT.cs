using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A35 RID: 18997
	public class ITrapDefenseSpawnMonsterConditionOpenT
	{
		// Token: 0x17008543 RID: 34115
		// (get) Token: 0x0601C862 RID: 116834 RVA: 0x00406A64 File Offset: 0x00404C64
		// (set) Token: 0x0601C863 RID: 116835 RVA: 0x00406A6C File Offset: 0x00404C6C
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x17008544 RID: 34116
		// (get) Token: 0x0601C864 RID: 116836 RVA: 0x00406A75 File Offset: 0x00404C75
		// (set) Token: 0x0601C865 RID: 116837 RVA: 0x00406A7D File Offset: 0x00404C7D
		public int Id { get; set; }

		// Token: 0x0601C866 RID: 116838 RVA: 0x00406A86 File Offset: 0x00404C86
		public ITrapDefenseSpawnMonsterConditionOpenT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
			this.Id = 0;
		}
	}
}
