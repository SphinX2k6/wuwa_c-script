using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A38 RID: 19000
	public class ITrapDefenseSpawnMonsterGroupT
	{
		// Token: 0x1700854A RID: 34122
		// (get) Token: 0x0601C87C RID: 116860 RVA: 0x00406D3C File Offset: 0x00404F3C
		// (set) Token: 0x0601C87D RID: 116861 RVA: 0x00406D44 File Offset: 0x00404F44
		public int Id { get; set; }

		// Token: 0x1700854B RID: 34123
		// (get) Token: 0x0601C87E RID: 116862 RVA: 0x00406D4D File Offset: 0x00404F4D
		// (set) Token: 0x0601C87F RID: 116863 RVA: 0x00406D55 File Offset: 0x00404F55
		public int RepeatTimes { get; set; }

		// Token: 0x1700854C RID: 34124
		// (get) Token: 0x0601C880 RID: 116864 RVA: 0x00406D5E File Offset: 0x00404F5E
		// (set) Token: 0x0601C881 RID: 116865 RVA: 0x00406D66 File Offset: 0x00404F66
		public float RepeatDelayTime { get; set; }

		// Token: 0x1700854D RID: 34125
		// (get) Token: 0x0601C882 RID: 116866 RVA: 0x00406D6F File Offset: 0x00404F6F
		// (set) Token: 0x0601C883 RID: 116867 RVA: 0x00406D77 File Offset: 0x00404F77
		public float IntervalTime { get; set; }

		// Token: 0x0601C884 RID: 116868 RVA: 0x00406D80 File Offset: 0x00404F80
		public ITrapDefenseSpawnMonsterGroupT()
		{
			this.Id = 0;
			this.RepeatTimes = 0;
			this.RepeatDelayTime = 0f;
			this.IntervalTime = 0f;
		}
	}
}
