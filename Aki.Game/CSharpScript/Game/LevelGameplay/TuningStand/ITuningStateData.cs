using System;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069C3 RID: 27075
	public interface ITuningStateData
	{
		// Token: 0x17009865 RID: 39013
		// (get) Token: 0x060435E5 RID: 275941
		// (set) Token: 0x060435E6 RID: 275942
		EGridBelongType State { get; set; }

		// Token: 0x17009866 RID: 39014
		// (get) Token: 0x060435E7 RID: 275943
		// (set) Token: 0x060435E8 RID: 275944
		int? Prev { get; set; }

		// Token: 0x17009867 RID: 39015
		// (get) Token: 0x060435E9 RID: 275945
		// (set) Token: 0x060435EA RID: 275946
		int? Next { get; set; }
	}
}
