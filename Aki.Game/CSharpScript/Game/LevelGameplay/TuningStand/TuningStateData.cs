using System;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B22 RID: 23330
	public class TuningStateData : ITuningStateData
	{
		// Token: 0x17006D49 RID: 27977
		// (get) Token: 0x0603962E RID: 235054 RVA: 0x0101A89A File Offset: 0x01018A9A
		// (set) Token: 0x0603962F RID: 235055 RVA: 0x0101A8A2 File Offset: 0x01018AA2
		public EGridBelongType State { get; set; }

		// Token: 0x17006D4A RID: 27978
		// (get) Token: 0x06039630 RID: 235056 RVA: 0x0101A8AB File Offset: 0x01018AAB
		// (set) Token: 0x06039631 RID: 235057 RVA: 0x0101A8B3 File Offset: 0x01018AB3
		public int? Prev { get; set; }

		// Token: 0x17006D4B RID: 27979
		// (get) Token: 0x06039632 RID: 235058 RVA: 0x0101A8BC File Offset: 0x01018ABC
		// (set) Token: 0x06039633 RID: 235059 RVA: 0x0101A8C4 File Offset: 0x01018AC4
		public int? Next { get; set; }
	}
}
