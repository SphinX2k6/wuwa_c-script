using System;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069C6 RID: 27078
	public class TuningStateData : ITuningStateData
	{
		// Token: 0x17009869 RID: 39017
		// (get) Token: 0x060435F2 RID: 275954 RVA: 0x01076406 File Offset: 0x01074606
		// (set) Token: 0x060435F3 RID: 275955 RVA: 0x0107640E File Offset: 0x0107460E
		public EGridBelongType State { get; set; }

		// Token: 0x1700986A RID: 39018
		// (get) Token: 0x060435F4 RID: 275956 RVA: 0x01076417 File Offset: 0x01074617
		// (set) Token: 0x060435F5 RID: 275957 RVA: 0x0107641F File Offset: 0x0107461F
		public int? Prev { get; set; }

		// Token: 0x1700986B RID: 39019
		// (get) Token: 0x060435F6 RID: 275958 RVA: 0x01076428 File Offset: 0x01074628
		// (set) Token: 0x060435F7 RID: 275959 RVA: 0x01076430 File Offset: 0x01074630
		public int? Next { get; set; }
	}
}
