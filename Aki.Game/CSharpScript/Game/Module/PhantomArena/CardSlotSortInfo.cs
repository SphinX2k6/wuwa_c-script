using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005118 RID: 20760
	[RequiredMember]
	public class CardSlotSortInfo
	{
		// Token: 0x06035144 RID: 217412 RVA: 0x00C9419A File Offset: 0x00C9239A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardSlotSortInfo()
		{
		}

		// Token: 0x0401C469 RID: 115817
		[RequiredMember]
		public int CardId;

		// Token: 0x0401C46A RID: 115818
		[RequiredMember]
		public int Cost;

		// Token: 0x0401C46B RID: 115819
		[RequiredMember]
		public int Element;

		// Token: 0x0401C46C RID: 115820
		[RequiredMember]
		public ECardType CardType;
	}
}
