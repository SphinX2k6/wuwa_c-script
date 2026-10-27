using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005121 RID: 20769
	[RequiredMember]
	public class CardElementCount
	{
		// Token: 0x06035156 RID: 217430 RVA: 0x00C941CA File Offset: 0x00C923CA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardElementCount()
		{
		}

		// Token: 0x0401C481 RID: 115841
		[RequiredMember]
		public int ElementId;

		// Token: 0x0401C482 RID: 115842
		[RequiredMember]
		public int Count;

		// Token: 0x0401C483 RID: 115843
		[RequiredMember]
		public int All;
	}
}
