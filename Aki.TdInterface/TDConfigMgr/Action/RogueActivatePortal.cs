using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002170 RID: 8560
	public class RogueActivatePortal : ActionParams
	{
		// Token: 0x0600BC44 RID: 48196 RVA: 0x001B2316 File Offset: 0x001B0516
		[NullableContext(1)]
		public static RogueActivatePortal Create([Nullable(2)] RogueActivatePortal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueActivatePortal
			{
				FbInstance = instance
			};
		}

		// Token: 0x04007076 RID: 28790
		[Nullable(2)]
		protected new RogueActivatePortal FbInstance;
	}
}
