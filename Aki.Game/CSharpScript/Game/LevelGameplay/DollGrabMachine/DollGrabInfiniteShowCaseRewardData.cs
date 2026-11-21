using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006045 RID: 24645
	[RequiredMember]
	public class DollGrabInfiniteShowCaseRewardData : IDollGrabInfiniteShowCaseRewardData
	{
		// Token: 0x17006FEC RID: 28652
		// (get) Token: 0x0603B26D RID: 242285 RVA: 0x010B9097 File Offset: 0x010B7297
		// (set) Token: 0x0603B26E RID: 242286 RVA: 0x010B909F File Offset: 0x010B729F
		[RequiredMember]
		public int DropId { get; set; }

		// Token: 0x17006FED RID: 28653
		// (get) Token: 0x0603B26F RID: 242287 RVA: 0x010B90A8 File Offset: 0x010B72A8
		// (set) Token: 0x0603B270 RID: 242288 RVA: 0x010B90B0 File Offset: 0x010B72B0
		[RequiredMember]
		public int GetRewardIndex { get; set; }

		// Token: 0x17006FEE RID: 28654
		// (get) Token: 0x0603B271 RID: 242289 RVA: 0x010B90B9 File Offset: 0x010B72B9
		// (set) Token: 0x0603B272 RID: 242290 RVA: 0x010B90C1 File Offset: 0x010B72C1
		[RequiredMember]
		public int NextRewardIndex { get; set; }

		// Token: 0x0603B273 RID: 242291 RVA: 0x010B90CA File Offset: 0x010B72CA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollGrabInfiniteShowCaseRewardData()
		{
		}
	}
}
