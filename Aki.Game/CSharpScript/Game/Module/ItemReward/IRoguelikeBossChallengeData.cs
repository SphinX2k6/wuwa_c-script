using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E4 RID: 22500
	[NullableContext(1)]
	public interface IRoguelikeBossChallengeData
	{
		// Token: 0x170089F4 RID: 35316
		// (get) Token: 0x060392FE RID: 234238
		// (set) Token: 0x060392FF RID: 234239
		bool IsNewRecord { get; set; }

		// Token: 0x170089F5 RID: 35317
		// (get) Token: 0x06039300 RID: 234240
		// (set) Token: 0x06039301 RID: 234241
		int PassTime { get; set; }

		// Token: 0x170089F6 RID: 35318
		// (get) Token: 0x06039302 RID: 234242
		// (set) Token: 0x06039303 RID: 234243
		int InstId { get; set; }

		// Token: 0x170089F7 RID: 35319
		// (get) Token: 0x06039304 RID: 234244
		// (set) Token: 0x06039305 RID: 234245
		int BossTotalCount { get; set; }

		// Token: 0x170089F8 RID: 35320
		// (get) Token: 0x06039306 RID: 234246
		// (set) Token: 0x06039307 RID: 234247
		IReadOnlyList<int> FinishedBossIdList { get; set; }

		// Token: 0x170089F9 RID: 35321
		// (get) Token: 0x06039308 RID: 234248
		// (set) Token: 0x06039309 RID: 234249
		int? CurrentBossId { get; set; }
	}
}
