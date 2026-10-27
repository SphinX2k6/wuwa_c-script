using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045CD RID: 17869
	public class ITrapDefenseSpawnMonsterConditionOpenT
	{
		// Token: 0x17007F02 RID: 32514
		// (get) Token: 0x0601B08D RID: 110733 RVA: 0x003DA7C8 File Offset: 0x003D89C8
		// (set) Token: 0x0601B08E RID: 110734 RVA: 0x003DA7D0 File Offset: 0x003D89D0
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x17007F03 RID: 32515
		// (get) Token: 0x0601B08F RID: 110735 RVA: 0x003DA7D9 File Offset: 0x003D89D9
		// (set) Token: 0x0601B090 RID: 110736 RVA: 0x003DA7E1 File Offset: 0x003D89E1
		public int Id { get; set; }

		// Token: 0x0601B091 RID: 110737 RVA: 0x003DA7EA File Offset: 0x003D89EA
		public ITrapDefenseSpawnMonsterConditionOpenT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
			this.Id = 0;
		}
	}
}
