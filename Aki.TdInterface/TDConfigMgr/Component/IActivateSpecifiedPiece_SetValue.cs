using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A0 RID: 416
	public class IActivateSpecifiedPiece_SetValue
	{
		// Token: 0x04000804 RID: 2052
		public EJigsawCompleteCondition Type;

		// Token: 0x04000805 RID: 2053
		[Nullable(1)]
		public List<IActivateSpecifiedPieceConfig> Config;
	}
}
