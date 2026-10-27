using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005129 RID: 20777
	[RequiredMember]
	public class RewardTuple
	{
		// Token: 0x0603515E RID: 217438 RVA: 0x00C9420A File Offset: 0x00C9240A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RewardTuple()
		{
		}

		// Token: 0x0401C493 RID: 115859
		[RequiredMember]
		public int Id;

		// Token: 0x0401C494 RID: 115860
		[RequiredMember]
		public int Num;

		// Token: 0x0401C495 RID: 115861
		[RequiredMember]
		public bool Taken;
	}
}
