using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F39 RID: 24377
	[NullableContext(1)]
	public interface IWheelTowerPopupData
	{
		// Token: 0x17008F54 RID: 36692
		// (get) Token: 0x0603DECE RID: 253646
		// (set) Token: 0x0603DECF RID: 253647
		int TotalScore { get; set; }

		// Token: 0x17008F55 RID: 36693
		// (get) Token: 0x0603DED0 RID: 253648
		// (set) Token: 0x0603DED1 RID: 253649
		int RoundScore { get; set; }

		// Token: 0x17008F56 RID: 36694
		// (get) Token: 0x0603DED2 RID: 253650
		// (set) Token: 0x0603DED3 RID: 253651
		int ScoreRecord { get; set; }

		// Token: 0x17008F57 RID: 36695
		// (get) Token: 0x0603DED4 RID: 253652
		// (set) Token: 0x0603DED5 RID: 253653
		List<int> TeamRoleIdList { get; set; }

		// Token: 0x17008F58 RID: 36696
		// (get) Token: 0x0603DED6 RID: 253654
		// (set) Token: 0x0603DED7 RID: 253655
		int BuffId { get; set; }
	}
}
