using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC5 RID: 28357
	[RequiredMember]
	public class DollGrabInfiniteShowCaseRewardData : IDollGrabInfiniteShowCaseRewardData
	{
		// Token: 0x17009AB5 RID: 39605
		// (get) Token: 0x060450CC RID: 282828 RVA: 0x0110EFBB File Offset: 0x0110D1BB
		// (set) Token: 0x060450CD RID: 282829 RVA: 0x0110EFC3 File Offset: 0x0110D1C3
		[RequiredMember]
		public int DropId { get; set; }

		// Token: 0x17009AB6 RID: 39606
		// (get) Token: 0x060450CE RID: 282830 RVA: 0x0110EFCC File Offset: 0x0110D1CC
		// (set) Token: 0x060450CF RID: 282831 RVA: 0x0110EFD4 File Offset: 0x0110D1D4
		[RequiredMember]
		public int GetRewardIndex { get; set; }

		// Token: 0x17009AB7 RID: 39607
		// (get) Token: 0x060450D0 RID: 282832 RVA: 0x0110EFDD File Offset: 0x0110D1DD
		// (set) Token: 0x060450D1 RID: 282833 RVA: 0x0110EFE5 File Offset: 0x0110D1E5
		[RequiredMember]
		public int NextRewardIndex { get; set; }

		// Token: 0x060450D2 RID: 282834 RVA: 0x0110EFEE File Offset: 0x0110D1EE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollGrabInfiniteShowCaseRewardData()
		{
		}
	}
}
