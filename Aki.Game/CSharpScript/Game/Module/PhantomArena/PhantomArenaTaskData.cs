using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004104 RID: 16644
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PhantomArenaTaskData
	{
		// Token: 0x0602A062 RID: 172130 RVA: 0x00BE1676 File Offset: 0x00BDF876
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaTaskData()
		{
		}

		// Token: 0x04016EE5 RID: 93925
		[RequiredMember]
		public ActivityTask TaskConfig;

		// Token: 0x04016EE6 RID: 93926
		[RequiredMember]
		public List<TItem> Reward;
	}
}
