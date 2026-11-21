using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A2F RID: 18991
	public class ITrapDefenseSpawnMonsterConditionCompletedT
	{
		// Token: 0x17008538 RID: 34104
		// (get) Token: 0x0601C826 RID: 116774 RVA: 0x00406264 File Offset: 0x00404464
		// (set) Token: 0x0601C827 RID: 116775 RVA: 0x0040626C File Offset: 0x0040446C
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x17008539 RID: 34105
		// (get) Token: 0x0601C828 RID: 116776 RVA: 0x00406275 File Offset: 0x00404475
		// (set) Token: 0x0601C829 RID: 116777 RVA: 0x0040627D File Offset: 0x0040447D
		public int Id { get; set; }

		// Token: 0x0601C82A RID: 116778 RVA: 0x00406286 File Offset: 0x00404486
		public ITrapDefenseSpawnMonsterConditionCompletedT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
			this.Id = 0;
		}
	}
}
