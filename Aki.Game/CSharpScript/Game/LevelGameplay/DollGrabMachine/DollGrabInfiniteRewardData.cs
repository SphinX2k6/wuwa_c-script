using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC1 RID: 28353
	[RequiredMember]
	public class DollGrabInfiniteRewardData : IDollGrabInfiniteRewardData
	{
		// Token: 0x17009AA7 RID: 39591
		// (get) Token: 0x060450AC RID: 282796 RVA: 0x0110EDCF File Offset: 0x0110CFCF
		// (set) Token: 0x060450AD RID: 282797 RVA: 0x0110EDD7 File Offset: 0x0110CFD7
		[RequiredMember]
		public int DropId { get; set; }

		// Token: 0x17009AA8 RID: 39592
		// (get) Token: 0x060450AE RID: 282798 RVA: 0x0110EDE0 File Offset: 0x0110CFE0
		// (set) Token: 0x060450AF RID: 282799 RVA: 0x0110EDE8 File Offset: 0x0110CFE8
		[RequiredMember]
		public int CurrentScore { get; set; }

		// Token: 0x17009AA9 RID: 39593
		// (get) Token: 0x060450B0 RID: 282800 RVA: 0x0110EDF1 File Offset: 0x0110CFF1
		// (set) Token: 0x060450B1 RID: 282801 RVA: 0x0110EDF9 File Offset: 0x0110CFF9
		[RequiredMember]
		public int CurrentAccumulatedScore { get; set; }

		// Token: 0x17009AAA RID: 39594
		// (get) Token: 0x060450B2 RID: 282802 RVA: 0x0110EE02 File Offset: 0x0110D002
		// (set) Token: 0x060450B3 RID: 282803 RVA: 0x0110EE0A File Offset: 0x0110D00A
		[RequiredMember]
		public int TargetAccumulatedScore { get; set; }

		// Token: 0x17009AAB RID: 39595
		// (get) Token: 0x060450B4 RID: 282804 RVA: 0x0110EE13 File Offset: 0x0110D013
		// (set) Token: 0x060450B5 RID: 282805 RVA: 0x0110EE1B File Offset: 0x0110D01B
		[RequiredMember]
		public int HighestScore { get; set; }

		// Token: 0x17009AAC RID: 39596
		// (get) Token: 0x060450B6 RID: 282806 RVA: 0x0110EE24 File Offset: 0x0110D024
		// (set) Token: 0x060450B7 RID: 282807 RVA: 0x0110EE2C File Offset: 0x0110D02C
		[RequiredMember]
		public bool IsFinalReward { get; set; }

		// Token: 0x17009AAD RID: 39597
		// (get) Token: 0x060450B8 RID: 282808 RVA: 0x0110EE35 File Offset: 0x0110D035
		// (set) Token: 0x060450B9 RID: 282809 RVA: 0x0110EE3D File Offset: 0x0110D03D
		[RequiredMember]
		public bool IsFirstGetReward { get; set; }

		// Token: 0x060450BA RID: 282810 RVA: 0x0110EE46 File Offset: 0x0110D046
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollGrabInfiniteRewardData()
		{
		}
	}
}
