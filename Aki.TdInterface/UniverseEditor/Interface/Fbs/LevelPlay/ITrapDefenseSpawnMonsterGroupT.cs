using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D0 RID: 17872
	public class ITrapDefenseSpawnMonsterGroupT
	{
		// Token: 0x17007F09 RID: 32521
		// (get) Token: 0x0601B0A7 RID: 110759 RVA: 0x003DAAA0 File Offset: 0x003D8CA0
		// (set) Token: 0x0601B0A8 RID: 110760 RVA: 0x003DAAA8 File Offset: 0x003D8CA8
		public int Id { get; set; }

		// Token: 0x17007F0A RID: 32522
		// (get) Token: 0x0601B0A9 RID: 110761 RVA: 0x003DAAB1 File Offset: 0x003D8CB1
		// (set) Token: 0x0601B0AA RID: 110762 RVA: 0x003DAAB9 File Offset: 0x003D8CB9
		public int RepeatTimes { get; set; }

		// Token: 0x17007F0B RID: 32523
		// (get) Token: 0x0601B0AB RID: 110763 RVA: 0x003DAAC2 File Offset: 0x003D8CC2
		// (set) Token: 0x0601B0AC RID: 110764 RVA: 0x003DAACA File Offset: 0x003D8CCA
		public float RepeatDelayTime { get; set; }

		// Token: 0x17007F0C RID: 32524
		// (get) Token: 0x0601B0AD RID: 110765 RVA: 0x003DAAD3 File Offset: 0x003D8CD3
		// (set) Token: 0x0601B0AE RID: 110766 RVA: 0x003DAADB File Offset: 0x003D8CDB
		public float IntervalTime { get; set; }

		// Token: 0x0601B0AF RID: 110767 RVA: 0x003DAAE4 File Offset: 0x003D8CE4
		public ITrapDefenseSpawnMonsterGroupT()
		{
			this.Id = 0;
			this.RepeatTimes = 0;
			this.RepeatDelayTime = 0f;
			this.IntervalTime = 0f;
		}
	}
}
