using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B6 RID: 6326
	public class GetRewardByInteract : ActionParams
	{
		// Token: 0x060084B3 RID: 33971 RVA: 0x0013CB1A File Offset: 0x0013AD1A
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

		// Token: 0x0400546D RID: 21613
		[Nullable(2)]
		protected new GetRewardByInteract FbInstance;
	}
}
