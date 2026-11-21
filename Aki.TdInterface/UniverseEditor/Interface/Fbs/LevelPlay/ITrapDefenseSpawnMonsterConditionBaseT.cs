using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A29 RID: 18985
	public class ITrapDefenseSpawnMonsterConditionBaseT
	{
		// Token: 0x17008532 RID: 34098
		// (get) Token: 0x0601C802 RID: 116738 RVA: 0x00405EFE File Offset: 0x004040FE
		// (set) Token: 0x0601C803 RID: 116739 RVA: 0x00405F06 File Offset: 0x00404106
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x0601C804 RID: 116740 RVA: 0x00405F0F File Offset: 0x0040410F
		public ITrapDefenseSpawnMonsterConditionBaseT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
		}
	}
}
