using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001487 RID: 5255
	public class ActivateResetPoint : ActionParams
	{
		// Token: 0x06007794 RID: 30612 RVA: 0x0011F0B9 File Offset: 0x0011D2B9
		[NullableContext(1)]
		public static ActivateResetPoint Create([Nullable(2)] ActivateResetPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateResetPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0400458E RID: 17806
		[Nullable(2)]
		protected new ActivateResetPoint FbInstance;
	}
}
