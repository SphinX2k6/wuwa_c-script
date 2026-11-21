using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C28 RID: 15400
	internal interface ILocatedLoopPosition
	{
		// Token: 0x1700507C RID: 20604
		// (get) Token: 0x0602773A RID: 161594
		// (set) Token: 0x0602773B RID: 161595
		ESeason Season { get; set; }

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x0602773C RID: 161596
		// (set) Token: 0x0602773D RID: 161597
		ESeasonLoopPhase Phase { get; set; }
	}
}
