using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F4 RID: 16628
	[RequiredMember]
	public class RemoveCardContext
	{
		// Token: 0x0602A052 RID: 172114 RVA: 0x00BE15F6 File Offset: 0x00BDF7F6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RemoveCardContext()
		{
		}

		// Token: 0x04016EC0 RID: 93888
		[RequiredMember]
		public int CardId;

		// Token: 0x04016EC1 RID: 93889
		[RequiredMember]
		public int RemoveCount;
	}
}
