using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F9 RID: 16633
	[RequiredMember]
	public class RewardTuple
	{
		// Token: 0x0602A057 RID: 172119 RVA: 0x00BE161E File Offset: 0x00BDF81E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RewardTuple()
		{
		}

		// Token: 0x04016EC8 RID: 93896
		[RequiredMember]
		public int Id;

		// Token: 0x04016EC9 RID: 93897
		[RequiredMember]
		public int Num;

		// Token: 0x04016ECA RID: 93898
		[RequiredMember]
		public bool Taken;
	}
}
