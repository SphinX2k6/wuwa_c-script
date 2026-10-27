using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005124 RID: 20772
	[RequiredMember]
	public class RemoveCardContext
	{
		// Token: 0x06035159 RID: 217433 RVA: 0x00C941E2 File Offset: 0x00C923E2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RemoveCardContext()
		{
		}

		// Token: 0x0401C48B RID: 115851
		[RequiredMember]
		public int CardId;

		// Token: 0x0401C48C RID: 115852
		[RequiredMember]
		public int RemoveCount;
	}
}
