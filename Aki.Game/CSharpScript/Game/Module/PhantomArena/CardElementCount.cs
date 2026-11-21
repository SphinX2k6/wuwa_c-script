using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F1 RID: 16625
	[RequiredMember]
	public class CardElementCount
	{
		// Token: 0x0602A04F RID: 172111 RVA: 0x00BE15DE File Offset: 0x00BDF7DE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardElementCount()
		{
		}

		// Token: 0x04016EB6 RID: 93878
		[RequiredMember]
		public int ElementId;

		// Token: 0x04016EB7 RID: 93879
		[RequiredMember]
		public int Count;

		// Token: 0x04016EB8 RID: 93880
		[RequiredMember]
		public int All;
	}
}
