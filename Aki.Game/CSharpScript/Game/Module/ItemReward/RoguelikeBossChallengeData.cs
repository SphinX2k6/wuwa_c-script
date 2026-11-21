using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047BC RID: 18364
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeData : IRoguelikeBossChallengeData
	{
		// Token: 0x17005DC4 RID: 24004
		// (get) Token: 0x0602E21E RID: 188958 RVA: 0x00CDF22A File Offset: 0x00CDD42A
		// (set) Token: 0x0602E21F RID: 188959 RVA: 0x00CDF232 File Offset: 0x00CDD432
		public bool IsNewRecord { get; set; }

		// Token: 0x17005DC5 RID: 24005
		// (get) Token: 0x0602E220 RID: 188960 RVA: 0x00CDF23B File Offset: 0x00CDD43B
		// (set) Token: 0x0602E221 RID: 188961 RVA: 0x00CDF243 File Offset: 0x00CDD443
		public int PassTime { get; set; }

		// Token: 0x17005DC6 RID: 24006
		// (get) Token: 0x0602E222 RID: 188962 RVA: 0x00CDF24C File Offset: 0x00CDD44C
		// (set) Token: 0x0602E223 RID: 188963 RVA: 0x00CDF254 File Offset: 0x00CDD454
		public int InstId { get; set; }

		// Token: 0x17005DC7 RID: 24007
		// (get) Token: 0x0602E224 RID: 188964 RVA: 0x00CDF25D File Offset: 0x00CDD45D
		// (set) Token: 0x0602E225 RID: 188965 RVA: 0x00CDF265 File Offset: 0x00CDD465
		public int BossTotalCount { get; set; }

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x0602E226 RID: 188966 RVA: 0x00CDF26E File Offset: 0x00CDD46E
		// (set) Token: 0x0602E227 RID: 188967 RVA: 0x00CDF276 File Offset: 0x00CDD476
		public IReadOnlyList<int> FinishedBossIdList { get; set; }

		// Token: 0x17005DC9 RID: 24009
		// (get) Token: 0x0602E228 RID: 188968 RVA: 0x00CDF27F File Offset: 0x00CDD47F
		// (set) Token: 0x0602E229 RID: 188969 RVA: 0x00CDF287 File Offset: 0x00CDD487
		public int? CurrentBossId { get; set; }
	}
}
