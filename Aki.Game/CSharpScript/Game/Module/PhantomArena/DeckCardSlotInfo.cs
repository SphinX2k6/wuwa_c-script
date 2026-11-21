using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F2 RID: 16626
	[RequiredMember]
	public class DeckCardSlotInfo : CardSlotSortInfo
	{
		// Token: 0x0602A050 RID: 172112 RVA: 0x00BE15E6 File Offset: 0x00BDF7E6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckCardSlotInfo()
		{
		}

		// Token: 0x04016EB9 RID: 93881
		[RequiredMember]
		public int Count;
	}
}
