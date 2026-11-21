using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F20 RID: 20256
	[NullableContext(1)]
	public interface IWheelTowerPopupData
	{
		// Token: 0x17006326 RID: 25382
		// (get) Token: 0x06032E69 RID: 208489
		// (set) Token: 0x06032E6A RID: 208490
		int TotalScore { get; set; }

		// Token: 0x17006327 RID: 25383
		// (get) Token: 0x06032E6B RID: 208491
		// (set) Token: 0x06032E6C RID: 208492
		int RoundScore { get; set; }

		// Token: 0x17006328 RID: 25384
		// (get) Token: 0x06032E6D RID: 208493
		// (set) Token: 0x06032E6E RID: 208494
		int ScoreRecord { get; set; }

		// Token: 0x17006329 RID: 25385
		// (get) Token: 0x06032E6F RID: 208495
		// (set) Token: 0x06032E70 RID: 208496
		List<int> TeamRoleIdList { get; set; }

		// Token: 0x1700632A RID: 25386
		// (get) Token: 0x06032E71 RID: 208497
		// (set) Token: 0x06032E72 RID: 208498
		int BuffId { get; set; }
	}
}
