using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001723 RID: 5923
	public class FinishState : ActionParams
	{
		// Token: 0x06007D71 RID: 32113 RVA: 0x0012CF76 File Offset: 0x0012B176
		[NullableContext(1)]
		public static FinishState Create([Nullable(2)] FinishState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400500F RID: 20495
		[Nullable(2)]
		protected new FinishState FbInstance;
	}
}
