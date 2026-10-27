using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200511D RID: 20765
	[RequiredMember]
	public class CardFilterContext
	{
		// Token: 0x06035152 RID: 217426 RVA: 0x00C941AA File Offset: 0x00C923AA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardFilterContext()
		{
		}

		// Token: 0x0401C46F RID: 115823
		[RequiredMember]
		public ECardCostFilter CostFilter;

		// Token: 0x0401C470 RID: 115824
		[RequiredMember]
		public ECardTabType ElementFilter;

		// Token: 0x0401C471 RID: 115825
		[RequiredMember]
		public bool IncludeLocked;
	}
}
