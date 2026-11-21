using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004900 RID: 18688
	public class IDartStrategyErrorT
	{
		// Token: 0x17008222 RID: 33314
		// (get) Token: 0x0601BB01 RID: 113409 RVA: 0x003EA22B File Offset: 0x003E842B
		// (set) Token: 0x0601BB02 RID: 113410 RVA: 0x003EA233 File Offset: 0x003E8433
		public int Probability { get; set; }

		// Token: 0x17008223 RID: 33315
		// (get) Token: 0x0601BB03 RID: 113411 RVA: 0x003EA23C File Offset: 0x003E843C
		// (set) Token: 0x0601BB04 RID: 113412 RVA: 0x003EA244 File Offset: 0x003E8444
		public List<TDartboardZoneUnion> Zones { get; set; }

		// Token: 0x0601BB05 RID: 113413 RVA: 0x003EA24D File Offset: 0x003E844D
		public IDartStrategyErrorT()
		{
			this.Probability = 0;
			this.Zones = null;
		}
	}
}
