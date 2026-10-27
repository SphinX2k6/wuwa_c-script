using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005122 RID: 20770
	[RequiredMember]
	public class DeckCardSlotInfo : CardSlotSortInfo
	{
		// Token: 0x06035157 RID: 217431 RVA: 0x00C941D2 File Offset: 0x00C923D2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckCardSlotInfo()
		{
		}

		// Token: 0x0401C484 RID: 115844
		[RequiredMember]
		public int Count;
	}
}
