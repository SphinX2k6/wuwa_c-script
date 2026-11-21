using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B27 RID: 15143
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TargetDescribeAndScore : ITargetDescribeAndScore
	{
		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x06026EDD RID: 159453 RVA: 0x00AE53E8 File Offset: 0x00AE35E8
		// (set) Token: 0x06026EDE RID: 159454 RVA: 0x00AE53F0 File Offset: 0x00AE35F0
		[RequiredMember]
		public string DescribeTextKey { get; set; }

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x06026EDF RID: 159455 RVA: 0x00AE53F9 File Offset: 0x00AE35F9
		// (set) Token: 0x06026EE0 RID: 159456 RVA: 0x00AE5401 File Offset: 0x00AE3601
		[RequiredMember]
		public int RewardId { get; set; }

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06026EE1 RID: 159457 RVA: 0x00AE540A File Offset: 0x00AE360A
		// (set) Token: 0x06026EE2 RID: 159458 RVA: 0x00AE5412 File Offset: 0x00AE3612
		[RequiredMember]
		public int Score { get; set; }

		// Token: 0x06026EE3 RID: 159459 RVA: 0x00AE541B File Offset: 0x00AE361B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TargetDescribeAndScore()
		{
		}
	}
}
