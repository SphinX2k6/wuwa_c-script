using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C77 RID: 19575
	internal interface ILocatedLoopPosition
	{
		// Token: 0x17007CD2 RID: 31954
		// (get) Token: 0x06032987 RID: 207239
		// (set) Token: 0x06032988 RID: 207240
		ESeason Season { get; set; }

		// Token: 0x17007CD3 RID: 31955
		// (get) Token: 0x06032989 RID: 207241
		// (set) Token: 0x0603298A RID: 207242
		ESeasonLoopPhase Phase { get; set; }
	}
}
