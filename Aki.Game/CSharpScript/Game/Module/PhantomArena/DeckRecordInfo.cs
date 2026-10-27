using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005125 RID: 20773
	[RequiredMember]
	public class DeckRecordInfo
	{
		// Token: 0x0603515A RID: 217434 RVA: 0x00C941EA File Offset: 0x00C923EA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckRecordInfo()
		{
		}

		// Token: 0x0401C48D RID: 115853
		[Nullable(1)]
		[RequiredMember]
		public Dictionary<int, int> CardMap;
	}
}
