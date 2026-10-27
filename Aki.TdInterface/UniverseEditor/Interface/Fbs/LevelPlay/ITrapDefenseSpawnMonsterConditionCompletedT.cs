using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C7 RID: 17863
	public class ITrapDefenseSpawnMonsterConditionCompletedT
	{
		// Token: 0x17007EF7 RID: 32503
		// (get) Token: 0x0601B051 RID: 110673 RVA: 0x003D9FC8 File Offset: 0x003D81C8
		// (set) Token: 0x0601B052 RID: 110674 RVA: 0x003D9FD0 File Offset: 0x003D81D0
		public ETrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x17007EF8 RID: 32504
		// (get) Token: 0x0601B053 RID: 110675 RVA: 0x003D9FD9 File Offset: 0x003D81D9
		// (set) Token: 0x0601B054 RID: 110676 RVA: 0x003D9FE1 File Offset: 0x003D81E1
		public int Id { get; set; }

		// Token: 0x0601B055 RID: 110677 RVA: 0x003D9FEA File Offset: 0x003D81EA
		public ITrapDefenseSpawnMonsterConditionCompletedT()
		{
			this.Type = ETrapDefenseSpawnMonsterCondition.Completed;
			this.Id = 0;
		}
	}
}
