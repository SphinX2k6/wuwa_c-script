using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040ED RID: 16621
	[RequiredMember]
	public class CardFilterContext
	{
		// Token: 0x0602A04B RID: 172107 RVA: 0x00BE15BE File Offset: 0x00BDF7BE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardFilterContext()
		{
		}

		// Token: 0x04016EA4 RID: 93860
		[RequiredMember]
		public ECardCostFilter CostFilter;

		// Token: 0x04016EA5 RID: 93861
		[RequiredMember]
		public ECardTabType ElementFilter;

		// Token: 0x04016EA6 RID: 93862
		[RequiredMember]
		public bool IncludeLocked;
	}
}
