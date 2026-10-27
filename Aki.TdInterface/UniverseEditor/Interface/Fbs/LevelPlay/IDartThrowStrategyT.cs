using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200449B RID: 17563
	public class IDartThrowStrategyT
	{
		// Token: 0x17007BED RID: 31725
		// (get) Token: 0x0601A37A RID: 107386 RVA: 0x003BF100 File Offset: 0x003BD300
		// (set) Token: 0x0601A37B RID: 107387 RVA: 0x003BF108 File Offset: 0x003BD308
		public List<TDartboardZoneUnion> FinalRoundZones { get; set; }

		// Token: 0x17007BEE RID: 31726
		// (get) Token: 0x0601A37C RID: 107388 RVA: 0x003BF111 File Offset: 0x003BD311
		// (set) Token: 0x0601A37D RID: 107389 RVA: 0x003BF119 File Offset: 0x003BD319
		public List<TDartboardZoneUnion> CatchUpZones { get; set; }

		// Token: 0x17007BEF RID: 31727
		// (get) Token: 0x0601A37E RID: 107390 RVA: 0x003BF122 File Offset: 0x003BD322
		// (set) Token: 0x0601A37F RID: 107391 RVA: 0x003BF12A File Offset: 0x003BD32A
		public List<TDartboardZoneUnion> NormalZones { get; set; }

		// Token: 0x17007BF0 RID: 31728
		// (get) Token: 0x0601A380 RID: 107392 RVA: 0x003BF133 File Offset: 0x003BD333
		// (set) Token: 0x0601A381 RID: 107393 RVA: 0x003BF13B File Offset: 0x003BD33B
		public IDartStrategyErrorT Error { get; set; }

		// Token: 0x0601A382 RID: 107394 RVA: 0x003BF144 File Offset: 0x003BD344
		public IDartThrowStrategyT()
		{
			this.FinalRoundZones = null;
			this.CatchUpZones = null;
			this.NormalZones = null;
			this.Error = null;
		}
	}
}
