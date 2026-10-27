using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057CF RID: 22479
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScoreBelongHalfAreaItem : IRewardExploreScoreBelongHalfAreaItem
	{
		// Token: 0x170089AF RID: 35247
		// (get) Token: 0x06039269 RID: 234089 RVA: 0x00D9011A File Offset: 0x00D8E31A
		// (set) Token: 0x0603926A RID: 234090 RVA: 0x00D90122 File Offset: 0x00D8E322
		public string Target { get; set; }

		// Token: 0x170089B0 RID: 35248
		// (get) Token: 0x0603926B RID: 234091 RVA: 0x00D9012B File Offset: 0x00D8E32B
		// (set) Token: 0x0603926C RID: 234092 RVA: 0x00D90133 File Offset: 0x00D8E333
		public string DescriptionTextId { get; set; }

		// Token: 0x170089B1 RID: 35249
		// (get) Token: 0x0603926D RID: 234093 RVA: 0x00D9013C File Offset: 0x00D8E33C
		// (set) Token: 0x0603926E RID: 234094 RVA: 0x00D90144 File Offset: 0x00D8E344
		public ETeamBelong Belong { get; set; }
	}
}
