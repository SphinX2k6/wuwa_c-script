using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005123 RID: 20771
	[RequiredMember]
	public class AddCardContext
	{
		// Token: 0x06035158 RID: 217432 RVA: 0x00C941DA File Offset: 0x00C923DA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AddCardContext()
		{
		}

		// Token: 0x0401C485 RID: 115845
		[RequiredMember]
		public int CardId;

		// Token: 0x0401C486 RID: 115846
		[RequiredMember]
		public int Cost;

		// Token: 0x0401C487 RID: 115847
		[RequiredMember]
		public int Element;

		// Token: 0x0401C488 RID: 115848
		[RequiredMember]
		public int MaxCount;

		// Token: 0x0401C489 RID: 115849
		[RequiredMember]
		public int AddCount;

		// Token: 0x0401C48A RID: 115850
		[RequiredMember]
		public ECardType CardType;
	}
}
