using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040FD RID: 16637
	[RequiredMember]
	public class BadgeGroupCollectCountData
	{
		// Token: 0x0602A05B RID: 172123 RVA: 0x00BE163E File Offset: 0x00BDF83E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BadgeGroupCollectCountData()
		{
		}

		// Token: 0x04016ED2 RID: 93906
		[RequiredMember]
		public int Now;

		// Token: 0x04016ED3 RID: 93907
		[RequiredMember]
		public int Need;

		// Token: 0x04016ED4 RID: 93908
		[RequiredMember]
		public int All;
	}
}
