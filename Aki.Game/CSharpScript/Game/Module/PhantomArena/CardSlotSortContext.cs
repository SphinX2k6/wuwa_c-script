using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005119 RID: 20761
	[RequiredMember]
	public class CardSlotSortContext
	{
		// Token: 0x06035145 RID: 217413 RVA: 0x00C941A2 File Offset: 0x00C923A2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardSlotSortContext()
		{
		}

		// Token: 0x0401C46D RID: 115821
		[RequiredMember]
		public ECardSlotSortType SortType;

		// Token: 0x0401C46E RID: 115822
		[RequiredMember]
		public bool IsAscending;
	}
}
