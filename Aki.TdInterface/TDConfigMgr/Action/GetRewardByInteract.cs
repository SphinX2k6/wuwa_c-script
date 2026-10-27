using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001737 RID: 5943
	public class GetRewardByInteract : ActionParams
	{
		// Token: 0x06007DCB RID: 32203 RVA: 0x0012D972 File Offset: 0x0012BB72
		[NullableContext(1)]
		public static GetRewardByInteract Create([Nullable(2)] GetRewardByInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GetRewardByInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400503A RID: 20538
		[Nullable(2)]
		protected new GetRewardByInteract FbInstance;
	}
}
