using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D1 RID: 9169
	public class RogueActivatePortal : ActionParams
	{
		// Token: 0x0600C7D2 RID: 51154 RVA: 0x001C94CA File Offset: 0x001C76CA
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

		// Token: 0x040076AB RID: 30379
		[Nullable(2)]
		protected new RogueActivatePortal FbInstance;
	}
}
