using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A4 RID: 420
	public class IActiveRenjuPiece_SetValue
	{
		// Token: 0x04000812 RID: 2066
		public EJigsawCompleteCondition Type;

		// Token: 0x04000813 RID: 2067
		[Nullable(1)]
		public List<IRenjuConfig> RenjuConfig;

		// Token: 0x04000814 RID: 2068
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJigsawItemMatchedConfig> ExitMatchedConfig;
	}
}
