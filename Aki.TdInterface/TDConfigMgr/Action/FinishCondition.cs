using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200171F RID: 5919
	public class FinishCondition : ActionParams
	{
		// Token: 0x06007D65 RID: 32101 RVA: 0x0012CE84 File Offset: 0x0012B084
		[NullableContext(1)]
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

		// Token: 0x0400500A RID: 20490
		[Nullable(2)]
		protected new FinishCondition FbInstance;
	}
}
