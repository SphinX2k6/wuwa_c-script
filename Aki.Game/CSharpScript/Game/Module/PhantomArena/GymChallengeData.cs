using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F6 RID: 16630
	[RequiredMember]
	public class GymChallengeData
	{
		// Token: 0x0602A054 RID: 172116 RVA: 0x00BE1606 File Offset: 0x00BDF806
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GymChallengeData()
		{
		}

		// Token: 0x04016EC3 RID: 93891
		[RequiredMember]
		public int Id;

		// Token: 0x04016EC4 RID: 93892
		[RequiredMember]
		public EChallengeState State;

		// Token: 0x04016EC5 RID: 93893
		[RequiredMember]
		public bool IsLast;
	}
}
