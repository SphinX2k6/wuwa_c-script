using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005126 RID: 20774
	[RequiredMember]
	public class GymChallengeData
	{
		// Token: 0x0603515B RID: 217435 RVA: 0x00C941F2 File Offset: 0x00C923F2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GymChallengeData()
		{
		}

		// Token: 0x0401C48E RID: 115854
		[RequiredMember]
		public int Id;

		// Token: 0x0401C48F RID: 115855
		[RequiredMember]
		public EChallengeState State;

		// Token: 0x0401C490 RID: 115856
		[RequiredMember]
		public bool IsLast;
	}
}
