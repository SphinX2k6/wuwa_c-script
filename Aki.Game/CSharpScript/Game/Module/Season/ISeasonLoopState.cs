using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C7E RID: 19582
	public interface ISeasonLoopState
	{
		// Token: 0x17007CD7 RID: 31959
		// (get) Token: 0x060329BC RID: 207292
		// (set) Token: 0x060329BD RID: 207293
		ESeason CurrentSeason { get; set; }

		// Token: 0x17007CD8 RID: 31960
		// (get) Token: 0x060329BE RID: 207294
		// (set) Token: 0x060329BF RID: 207295
		ESeasonLoopPhase Phase { get; set; }

		// Token: 0x17007CD9 RID: 31961
		// (get) Token: 0x060329C0 RID: 207296
		// (set) Token: 0x060329C1 RID: 207297
		double PhaseElapsed { get; set; }
	}
}
