using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C2F RID: 15407
	public interface ISeasonLoopState
	{
		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x0602776F RID: 161647
		// (set) Token: 0x06027770 RID: 161648
		ESeason CurrentSeason { get; set; }

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x06027771 RID: 161649
		// (set) Token: 0x06027772 RID: 161650
		ESeasonLoopPhase Phase { get; set; }

		// Token: 0x17005083 RID: 20611
		// (get) Token: 0x06027773 RID: 161651
		// (set) Token: 0x06027774 RID: 161652
		double PhaseElapsed { get; set; }
	}
}
