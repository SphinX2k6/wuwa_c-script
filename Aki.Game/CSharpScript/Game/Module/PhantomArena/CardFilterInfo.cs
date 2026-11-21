using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040EE RID: 16622
	[RequiredMember]
	public class CardFilterInfo
	{
		// Token: 0x0602A04C RID: 172108 RVA: 0x00BE15C6 File Offset: 0x00BDF7C6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardFilterInfo()
		{
		}

		// Token: 0x04016EA7 RID: 93863
		[RequiredMember]
		public int CardId;

		// Token: 0x04016EA8 RID: 93864
		[RequiredMember]
		public int Cost;

		// Token: 0x04016EA9 RID: 93865
		[RequiredMember]
		public int Element;

		// Token: 0x04016EAA RID: 93866
		public bool IsLocked;
	}
}
