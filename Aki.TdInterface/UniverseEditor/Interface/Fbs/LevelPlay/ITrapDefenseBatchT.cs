using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045B5 RID: 17845
	public class ITrapDefenseBatchT
	{
		// Token: 0x17007ED8 RID: 32472
		// (get) Token: 0x0601AFC7 RID: 110535 RVA: 0x003D917F File Offset: 0x003D737F
		// (set) Token: 0x0601AFC8 RID: 110536 RVA: 0x003D9187 File Offset: 0x003D7387
		public List<int> Ids { get; set; }

		// Token: 0x17007ED9 RID: 32473
		// (get) Token: 0x0601AFC9 RID: 110537 RVA: 0x003D9190 File Offset: 0x003D7390
		// (set) Token: 0x0601AFCA RID: 110538 RVA: 0x003D9198 File Offset: 0x003D7398
		public int RepeatTimes { get; set; }

		// Token: 0x0601AFCB RID: 110539 RVA: 0x003D91A1 File Offset: 0x003D73A1
		public ITrapDefenseBatchT()
		{
			this.Ids = null;
			this.RepeatTimes = 0;
		}
	}
}
