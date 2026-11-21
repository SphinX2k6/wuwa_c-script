using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBA RID: 8122
	public class IRenjuChess_SetValue
	{
		// Token: 0x0400672A RID: 26410
		public ESimpleGameplayType Type;

		// Token: 0x0400672B RID: 26411
		public int Chessboard;

		// Token: 0x0400672C RID: 26412
		[Nullable(2)]
		public IAdjustPlayerCameraType CameraConfig;
	}
}
