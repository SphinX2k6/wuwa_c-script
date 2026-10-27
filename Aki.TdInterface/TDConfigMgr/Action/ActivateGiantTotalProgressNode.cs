using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001486 RID: 5254
	public class ActivateGiantTotalProgressNode : ActionParams
	{
		// Token: 0x06007792 RID: 30610 RVA: 0x0011F09E File Offset: 0x0011D29E
		[NullableContext(1)]
		public static ActivateGiantTotalProgressNode Create([Nullable(2)] ActivateGiantTotalProgressNode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateGiantTotalProgressNode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400458D RID: 17805
		[Nullable(2)]
		protected new ActivateGiantTotalProgressNode FbInstance;
	}
}
