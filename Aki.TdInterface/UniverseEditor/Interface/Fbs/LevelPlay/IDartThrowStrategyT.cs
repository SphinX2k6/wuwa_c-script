using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004903 RID: 18691
	public class IDartThrowStrategyT
	{
		// Token: 0x1700822C RID: 33324
		// (get) Token: 0x0601BB4B RID: 113483 RVA: 0x003EB30C File Offset: 0x003E950C
		// (set) Token: 0x0601BB4C RID: 113484 RVA: 0x003EB314 File Offset: 0x003E9514
		public List<TDartboardZoneUnion> FinalRoundZones { get; set; }

		// Token: 0x1700822D RID: 33325
		// (get) Token: 0x0601BB4D RID: 113485 RVA: 0x003EB31D File Offset: 0x003E951D
		// (set) Token: 0x0601BB4E RID: 113486 RVA: 0x003EB325 File Offset: 0x003E9525
		public List<TDartboardZoneUnion> CatchUpZones { get; set; }

		// Token: 0x1700822E RID: 33326
		// (get) Token: 0x0601BB4F RID: 113487 RVA: 0x003EB32E File Offset: 0x003E952E
		// (set) Token: 0x0601BB50 RID: 113488 RVA: 0x003EB336 File Offset: 0x003E9536
		public List<TDartboardZoneUnion> NormalZones { get; set; }

		// Token: 0x1700822F RID: 33327
		// (get) Token: 0x0601BB51 RID: 113489 RVA: 0x003EB33F File Offset: 0x003E953F
		// (set) Token: 0x0601BB52 RID: 113490 RVA: 0x003EB347 File Offset: 0x003E9547
		public IDartStrategyErrorT Error { get; set; }

		// Token: 0x0601BB53 RID: 113491 RVA: 0x003EB350 File Offset: 0x003E9550
		public IDartThrowStrategyT()
		{
			this.FinalRoundZones = null;
			this.CatchUpZones = null;
			this.NormalZones = null;
			this.Error = null;
		}
	}
}
