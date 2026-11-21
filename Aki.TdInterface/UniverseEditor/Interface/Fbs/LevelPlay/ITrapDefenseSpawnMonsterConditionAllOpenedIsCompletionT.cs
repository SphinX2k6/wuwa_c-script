using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A26 RID: 18982
	public class ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT
	{
		// Token: 0x1700852F RID: 34095
		// (get) Token: 0x0601C7F0 RID: 116720 RVA: 0x00405D86 File Offset: 0x00403F86
		// (set) Token: 0x0601C7F1 RID: 116721 RVA: 0x00405D8E File Offset: 0x00403F8E
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x0601C7F2 RID: 116722 RVA: 0x00405D97 File Offset: 0x00403F97
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
		}
	}
}
