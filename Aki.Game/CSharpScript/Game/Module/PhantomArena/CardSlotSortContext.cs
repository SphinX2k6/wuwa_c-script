using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040E9 RID: 16617
	[RequiredMember]
	public class CardSlotSortContext
	{
		// Token: 0x0602A03E RID: 172094 RVA: 0x00BE15B6 File Offset: 0x00BDF7B6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardSlotSortContext()
		{
		}

		// Token: 0x04016EA2 RID: 93858
		[RequiredMember]
		public ECardSlotSortType SortType;

		// Token: 0x04016EA3 RID: 93859
		[RequiredMember]
		public bool IsAscending;
	}
}
