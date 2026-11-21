using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F5 RID: 16629
	[RequiredMember]
	public class DeckRecordInfo
	{
		// Token: 0x0602A053 RID: 172115 RVA: 0x00BE15FE File Offset: 0x00BDF7FE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckRecordInfo()
		{
		}

		// Token: 0x04016EC2 RID: 93890
		[Nullable(1)]
		[RequiredMember]
		public Dictionary<int, int> CardMap;
	}
}
