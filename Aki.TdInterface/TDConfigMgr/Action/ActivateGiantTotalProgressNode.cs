using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DF RID: 5599
	public class ActivateGiantTotalProgressNode : ActionParams
	{
		// Token: 0x06007E5F RID: 32351 RVA: 0x0012DCEA File Offset: 0x0012BEEA
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

		// Token: 0x04004928 RID: 18728
		[Nullable(2)]
		protected new ActivateGiantTotalProgressNode FbInstance;
	}
}
