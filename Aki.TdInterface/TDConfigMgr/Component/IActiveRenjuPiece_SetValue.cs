using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BB RID: 443
	public class IActiveRenjuPiece_SetValue
	{
		// Token: 0x0400086B RID: 2155
		public EJigsawCompleteCondition Type;

		// Token: 0x0400086C RID: 2156
		public List<IRenjuConfig> RenjuConfig;

		// Token: 0x0400086D RID: 2157
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IJigsawItemMatchedConfig> ExitMatchedConfig;
	}
}
