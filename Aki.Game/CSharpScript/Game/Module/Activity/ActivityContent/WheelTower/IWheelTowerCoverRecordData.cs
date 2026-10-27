using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F35 RID: 24373
	[NullableContext(1)]
	public interface IWheelTowerCoverRecordData
	{
		// Token: 0x17008F38 RID: 36664
		// (get) Token: 0x0603DE94 RID: 253588
		// (set) Token: 0x0603DE95 RID: 253589
		int TotalScore { get; set; }

		// Token: 0x17008F39 RID: 36665
		// (get) Token: 0x0603DE96 RID: 253590
		// (set) Token: 0x0603DE97 RID: 253591
		int TeamScore { get; set; }

		// Token: 0x17008F3A RID: 36666
		// (get) Token: 0x0603DE98 RID: 253592
		// (set) Token: 0x0603DE99 RID: 253593
		List<int> TeamRoleIdList { get; set; }

		// Token: 0x17008F3B RID: 36667
		// (get) Token: 0x0603DE9A RID: 253594
		// (set) Token: 0x0603DE9B RID: 253595
		int BuffId { get; set; }

		// Token: 0x17008F3C RID: 36668
		// (get) Token: 0x0603DE9C RID: 253596
		// (set) Token: 0x0603DE9D RID: 253597
		int BossRound { get; set; }

		// Token: 0x17008F3D RID: 36669
		// (get) Token: 0x0603DE9E RID: 253598
		// (set) Token: 0x0603DE9F RID: 253599
		int BossWave { get; set; }

		// Token: 0x17008F3E RID: 36670
		// (get) Token: 0x0603DEA0 RID: 253600
		// (set) Token: 0x0603DEA1 RID: 253601
		int NeedChallengeBossWaveNum { get; set; }

		// Token: 0x17008F3F RID: 36671
		// (get) Token: 0x0603DEA2 RID: 253602
		// (set) Token: 0x0603DEA3 RID: 253603
		int AddTeamScore { get; set; }
	}
}
