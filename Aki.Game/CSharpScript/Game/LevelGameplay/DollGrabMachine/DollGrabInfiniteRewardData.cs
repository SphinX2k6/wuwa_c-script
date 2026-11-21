using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006041 RID: 24641
	[RequiredMember]
	public class DollGrabInfiniteRewardData : IDollGrabInfiniteRewardData
	{
		// Token: 0x17006FDE RID: 28638
		// (get) Token: 0x0603B24D RID: 242253 RVA: 0x010B8EAB File Offset: 0x010B70AB
		// (set) Token: 0x0603B24E RID: 242254 RVA: 0x010B8EB3 File Offset: 0x010B70B3
		[RequiredMember]
		public int DropId { get; set; }

		// Token: 0x17006FDF RID: 28639
		// (get) Token: 0x0603B24F RID: 242255 RVA: 0x010B8EBC File Offset: 0x010B70BC
		// (set) Token: 0x0603B250 RID: 242256 RVA: 0x010B8EC4 File Offset: 0x010B70C4
		[RequiredMember]
		public int CurrentScore { get; set; }

		// Token: 0x17006FE0 RID: 28640
		// (get) Token: 0x0603B251 RID: 242257 RVA: 0x010B8ECD File Offset: 0x010B70CD
		// (set) Token: 0x0603B252 RID: 242258 RVA: 0x010B8ED5 File Offset: 0x010B70D5
		[RequiredMember]
		public int CurrentAccumulatedScore { get; set; }

		// Token: 0x17006FE1 RID: 28641
		// (get) Token: 0x0603B253 RID: 242259 RVA: 0x010B8EDE File Offset: 0x010B70DE
		// (set) Token: 0x0603B254 RID: 242260 RVA: 0x010B8EE6 File Offset: 0x010B70E6
		[RequiredMember]
		public int TargetAccumulatedScore { get; set; }

		// Token: 0x17006FE2 RID: 28642
		// (get) Token: 0x0603B255 RID: 242261 RVA: 0x010B8EEF File Offset: 0x010B70EF
		// (set) Token: 0x0603B256 RID: 242262 RVA: 0x010B8EF7 File Offset: 0x010B70F7
		[RequiredMember]
		public int HighestScore { get; set; }

		// Token: 0x17006FE3 RID: 28643
		// (get) Token: 0x0603B257 RID: 242263 RVA: 0x010B8F00 File Offset: 0x010B7100
		// (set) Token: 0x0603B258 RID: 242264 RVA: 0x010B8F08 File Offset: 0x010B7108
		[RequiredMember]
		public bool IsFinalReward { get; set; }

		// Token: 0x17006FE4 RID: 28644
		// (get) Token: 0x0603B259 RID: 242265 RVA: 0x010B8F11 File Offset: 0x010B7111
		// (set) Token: 0x0603B25A RID: 242266 RVA: 0x010B8F19 File Offset: 0x010B7119
		[RequiredMember]
		public bool IsFirstGetReward { get; set; }

		// Token: 0x0603B25B RID: 242267 RVA: 0x010B8F22 File Offset: 0x010B7122
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollGrabInfiniteRewardData()
		{
		}
	}
}
