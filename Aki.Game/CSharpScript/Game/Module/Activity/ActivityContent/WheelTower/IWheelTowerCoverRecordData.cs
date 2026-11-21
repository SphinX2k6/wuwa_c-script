using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F1C RID: 20252
	[NullableContext(1)]
	public interface IWheelTowerCoverRecordData
	{
		// Token: 0x1700630A RID: 25354
		// (get) Token: 0x06032E2F RID: 208431
		// (set) Token: 0x06032E30 RID: 208432
		int TotalScore { get; set; }

		// Token: 0x1700630B RID: 25355
		// (get) Token: 0x06032E31 RID: 208433
		// (set) Token: 0x06032E32 RID: 208434
		int TeamScore { get; set; }

		// Token: 0x1700630C RID: 25356
		// (get) Token: 0x06032E33 RID: 208435
		// (set) Token: 0x06032E34 RID: 208436
		List<int> TeamRoleIdList { get; set; }

		// Token: 0x1700630D RID: 25357
		// (get) Token: 0x06032E35 RID: 208437
		// (set) Token: 0x06032E36 RID: 208438
		int BuffId { get; set; }

		// Token: 0x1700630E RID: 25358
		// (get) Token: 0x06032E37 RID: 208439
		// (set) Token: 0x06032E38 RID: 208440
		int BossRound { get; set; }

		// Token: 0x1700630F RID: 25359
		// (get) Token: 0x06032E39 RID: 208441
		// (set) Token: 0x06032E3A RID: 208442
		int BossWave { get; set; }

		// Token: 0x17006310 RID: 25360
		// (get) Token: 0x06032E3B RID: 208443
		// (set) Token: 0x06032E3C RID: 208444
		int NeedChallengeBossWaveNum { get; set; }

		// Token: 0x17006311 RID: 25361
		// (get) Token: 0x06032E3D RID: 208445
		// (set) Token: 0x06032E3E RID: 208446
		int AddTeamScore { get; set; }
	}
}
