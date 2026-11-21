using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040E8 RID: 16616
	[RequiredMember]
	public class CardSlotSortInfo
	{
		// Token: 0x0602A03D RID: 172093 RVA: 0x00BE15AE File Offset: 0x00BDF7AE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardSlotSortInfo()
		{
		}

		// Token: 0x04016E9E RID: 93854
		[RequiredMember]
		public int CardId;

		// Token: 0x04016E9F RID: 93855
		[RequiredMember]
		public int Cost;

		// Token: 0x04016EA0 RID: 93856
		[RequiredMember]
		public int Element;

		// Token: 0x04016EA1 RID: 93857
		[RequiredMember]
		public ECardType CardType;
	}
}
