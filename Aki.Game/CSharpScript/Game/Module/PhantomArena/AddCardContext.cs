using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F3 RID: 16627
	[RequiredMember]
	public class AddCardContext
	{
		// Token: 0x0602A051 RID: 172113 RVA: 0x00BE15EE File Offset: 0x00BDF7EE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AddCardContext()
		{
		}

		// Token: 0x04016EBA RID: 93882
		[RequiredMember]
		public int CardId;

		// Token: 0x04016EBB RID: 93883
		[RequiredMember]
		public int Cost;

		// Token: 0x04016EBC RID: 93884
		[RequiredMember]
		public int Element;

		// Token: 0x04016EBD RID: 93885
		[RequiredMember]
		public int MaxCount;

		// Token: 0x04016EBE RID: 93886
		[RequiredMember]
		public int AddCount;

		// Token: 0x04016EBF RID: 93887
		[RequiredMember]
		public ECardType CardType;
	}
}
