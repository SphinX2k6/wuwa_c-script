using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C1 RID: 17857
	public class ITrapDefenseSpawnMonsterConditionBaseT
	{
		// Token: 0x17007EF1 RID: 32497
		// (get) Token: 0x0601B02D RID: 110637 RVA: 0x003D9C62 File Offset: 0x003D7E62
		// (set) Token: 0x0601B02E RID: 110638 RVA: 0x003D9C6A File Offset: 0x003D7E6A
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x0601B02F RID: 110639 RVA: 0x003D9C73 File Offset: 0x003D7E73
		public ITrapDefenseSpawnMonsterConditionBaseT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
		}
	}
}
