using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047BB RID: 18363
	[NullableContext(1)]
	public interface IRoguelikeBossChallengeData
	{
		// Token: 0x17005DBE RID: 23998
		// (get) Token: 0x0602E212 RID: 188946
		// (set) Token: 0x0602E213 RID: 188947
		bool IsNewRecord { get; set; }

		// Token: 0x17005DBF RID: 23999
		// (get) Token: 0x0602E214 RID: 188948
		// (set) Token: 0x0602E215 RID: 188949
		int PassTime { get; set; }

		// Token: 0x17005DC0 RID: 24000
		// (get) Token: 0x0602E216 RID: 188950
		// (set) Token: 0x0602E217 RID: 188951
		int InstId { get; set; }

		// Token: 0x17005DC1 RID: 24001
		// (get) Token: 0x0602E218 RID: 188952
		// (set) Token: 0x0602E219 RID: 188953
		int BossTotalCount { get; set; }

		// Token: 0x17005DC2 RID: 24002
		// (get) Token: 0x0602E21A RID: 188954
		// (set) Token: 0x0602E21B RID: 188955
		IReadOnlyList<int> FinishedBossIdList { get; set; }

		// Token: 0x17005DC3 RID: 24003
		// (get) Token: 0x0602E21C RID: 188956
		// (set) Token: 0x0602E21D RID: 188957
		int? CurrentBossId { get; set; }
	}
}
