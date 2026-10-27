using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B7D RID: 19325
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TargetDescribeAndScore : ITargetDescribeAndScore
	{
		// Token: 0x17007C3B RID: 31803
		// (get) Token: 0x0603214C RID: 205132 RVA: 0x00BA1258 File Offset: 0x00B9F458
		// (set) Token: 0x0603214D RID: 205133 RVA: 0x00BA1260 File Offset: 0x00B9F460
		[RequiredMember]
		public string DescribeTextKey { get; set; }

		// Token: 0x17007C3C RID: 31804
		// (get) Token: 0x0603214E RID: 205134 RVA: 0x00BA1269 File Offset: 0x00B9F469
		// (set) Token: 0x0603214F RID: 205135 RVA: 0x00BA1271 File Offset: 0x00B9F471
		[RequiredMember]
		public int RewardId { get; set; }

		// Token: 0x17007C3D RID: 31805
		// (get) Token: 0x06032150 RID: 205136 RVA: 0x00BA127A File Offset: 0x00B9F47A
		// (set) Token: 0x06032151 RID: 205137 RVA: 0x00BA1282 File Offset: 0x00B9F482
		[RequiredMember]
		public int Score { get; set; }

		// Token: 0x06032152 RID: 205138 RVA: 0x00BA128B File Offset: 0x00B9F48B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TargetDescribeAndScore()
		{
		}
	}
}
