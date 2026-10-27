using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004498 RID: 17560
	public class IDartStrategyErrorT
	{
		// Token: 0x17007BE3 RID: 31715
		// (get) Token: 0x0601A330 RID: 107312 RVA: 0x003BE01F File Offset: 0x003BC21F
		// (set) Token: 0x0601A331 RID: 107313 RVA: 0x003BE027 File Offset: 0x003BC227
		public int Probability { get; set; }

		// Token: 0x17007BE4 RID: 31716
		// (get) Token: 0x0601A332 RID: 107314 RVA: 0x003BE030 File Offset: 0x003BC230
		// (set) Token: 0x0601A333 RID: 107315 RVA: 0x003BE038 File Offset: 0x003BC238
		public List<TDartboardZoneUnion> Zones { get; set; }

		// Token: 0x0601A334 RID: 107316 RVA: 0x003BE041 File Offset: 0x003BC241
		public IDartStrategyErrorT()
		{
			this.Probability = 0;
			this.Zones = null;
		}
	}
}
