using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F2F RID: 24367
	[NullableContext(1)]
	public interface IWheelTowerBossHandBookBuffData
	{
		// Token: 0x17008F26 RID: 36646
		// (get) Token: 0x0603DE6D RID: 253549
		// (set) Token: 0x0603DE6E RID: 253550
		int Round { get; set; }

		// Token: 0x17008F27 RID: 36647
		// (get) Token: 0x0603DE6F RID: 253551
		// (set) Token: 0x0603DE70 RID: 253552
		List<int> BuffIdList { get; set; }

		// Token: 0x17008F28 RID: 36648
		// (get) Token: 0x0603DE71 RID: 253553
		// (set) Token: 0x0603DE72 RID: 253554
		bool IsActivate { get; set; }
	}
}
