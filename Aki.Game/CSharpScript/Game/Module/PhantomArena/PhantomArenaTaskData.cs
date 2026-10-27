using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005134 RID: 20788
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PhantomArenaTaskData
	{
		// Token: 0x06035169 RID: 217449 RVA: 0x00C94262 File Offset: 0x00C92462
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaTaskData()
		{
		}

		// Token: 0x0401C4B0 RID: 115888
		[RequiredMember]
		public ActivityTask TaskConfig;

		// Token: 0x0401C4B1 RID: 115889
		[RequiredMember]
		public List<TItem> Reward;
	}
}
