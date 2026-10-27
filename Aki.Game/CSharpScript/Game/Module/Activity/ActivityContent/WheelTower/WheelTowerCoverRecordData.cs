using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F36 RID: 24374
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerCoverRecordData : IWheelTowerCoverRecordData
	{
		// Token: 0x17008F40 RID: 36672
		// (get) Token: 0x0603DEA4 RID: 253604 RVA: 0x00EF572D File Offset: 0x00EF392D
		// (set) Token: 0x0603DEA5 RID: 253605 RVA: 0x00EF5735 File Offset: 0x00EF3935
		public int TotalScore { get; set; }

		// Token: 0x17008F41 RID: 36673
		// (get) Token: 0x0603DEA6 RID: 253606 RVA: 0x00EF573E File Offset: 0x00EF393E
		// (set) Token: 0x0603DEA7 RID: 253607 RVA: 0x00EF5746 File Offset: 0x00EF3946
		public int TeamScore { get; set; }

		// Token: 0x17008F42 RID: 36674
		// (get) Token: 0x0603DEA8 RID: 253608 RVA: 0x00EF574F File Offset: 0x00EF394F
		// (set) Token: 0x0603DEA9 RID: 253609 RVA: 0x00EF5757 File Offset: 0x00EF3957
		public List<int> TeamRoleIdList { get; set; } = new List<int>();

		// Token: 0x17008F43 RID: 36675
		// (get) Token: 0x0603DEAA RID: 253610 RVA: 0x00EF5760 File Offset: 0x00EF3960
		// (set) Token: 0x0603DEAB RID: 253611 RVA: 0x00EF5768 File Offset: 0x00EF3968
		public int BuffId { get; set; }

		// Token: 0x17008F44 RID: 36676
		// (get) Token: 0x0603DEAC RID: 253612 RVA: 0x00EF5771 File Offset: 0x00EF3971
		// (set) Token: 0x0603DEAD RID: 253613 RVA: 0x00EF5779 File Offset: 0x00EF3979
		public int BossRound { get; set; }

		// Token: 0x17008F45 RID: 36677
		// (get) Token: 0x0603DEAE RID: 253614 RVA: 0x00EF5782 File Offset: 0x00EF3982
		// (set) Token: 0x0603DEAF RID: 253615 RVA: 0x00EF578A File Offset: 0x00EF398A
		public int BossWave { get; set; }

		// Token: 0x17008F46 RID: 36678
		// (get) Token: 0x0603DEB0 RID: 253616 RVA: 0x00EF5793 File Offset: 0x00EF3993
		// (set) Token: 0x0603DEB1 RID: 253617 RVA: 0x00EF579B File Offset: 0x00EF399B
		public int NeedChallengeBossWaveNum { get; set; }

		// Token: 0x17008F47 RID: 36679
		// (get) Token: 0x0603DEB2 RID: 253618 RVA: 0x00EF57A4 File Offset: 0x00EF39A4
		// (set) Token: 0x0603DEB3 RID: 253619 RVA: 0x00EF57AC File Offset: 0x00EF39AC
		public int AddTeamScore { get; set; }
	}
}
