using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045BE RID: 17854
	public class ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT
	{
		// Token: 0x17007EEE RID: 32494
		// (get) Token: 0x0601B01B RID: 110619 RVA: 0x003D9AEA File Offset: 0x003D7CEA
		// (set) Token: 0x0601B01C RID: 110620 RVA: 0x003D9AF2 File Offset: 0x003D7CF2
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x0601B01D RID: 110621 RVA: 0x003D9AFB File Offset: 0x003D7CFB
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
		}
	}
}
