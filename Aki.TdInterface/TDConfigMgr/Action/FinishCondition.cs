using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189C RID: 6300
	public class FinishCondition : ActionParams
	{
		// Token: 0x06008443 RID: 33859 RVA: 0x0013BF30 File Offset: 0x0013A130
		public static FinishCondition Create([Nullable(2)] FinishCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x04005439 RID: 21561
		[Nullable(2)]
		protected new FinishCondition FbInstance;
	}
}
