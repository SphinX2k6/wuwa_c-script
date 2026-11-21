using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F16 RID: 20246
	[NullableContext(1)]
	public interface IWheelTowerBossHandBookBuffData
	{
		// Token: 0x170062F8 RID: 25336
		// (get) Token: 0x06032E08 RID: 208392
		// (set) Token: 0x06032E09 RID: 208393
		int Round { get; set; }

		// Token: 0x170062F9 RID: 25337
		// (get) Token: 0x06032E0A RID: 208394
		// (set) Token: 0x06032E0B RID: 208395
		List<int> BuffIdList { get; set; }

		// Token: 0x170062FA RID: 25338
		// (get) Token: 0x06032E0C RID: 208396
		// (set) Token: 0x06032E0D RID: 208397
		bool IsActivate { get; set; }
	}
}
