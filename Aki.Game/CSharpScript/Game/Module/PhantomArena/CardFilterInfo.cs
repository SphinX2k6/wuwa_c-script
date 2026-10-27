using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200511E RID: 20766
	[RequiredMember]
	public class CardFilterInfo
	{
		// Token: 0x06035153 RID: 217427 RVA: 0x00C941B2 File Offset: 0x00C923B2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardFilterInfo()
		{
		}

		// Token: 0x0401C472 RID: 115826
		[RequiredMember]
		public int CardId;

		// Token: 0x0401C473 RID: 115827
		[RequiredMember]
		public int Cost;

		// Token: 0x0401C474 RID: 115828
		[RequiredMember]
		public int Element;

		// Token: 0x0401C475 RID: 115829
		public bool IsLocked;
	}
}
