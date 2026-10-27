using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA3 RID: 7587
	public class IRenjuChess_SetValue
	{
		// Token: 0x040061A2 RID: 24994
		public ESimpleGameplayType Type;

		// Token: 0x040061A3 RID: 24995
		public int Chessboard;

		// Token: 0x040061A4 RID: 24996
		[Nullable(2)]
		public IAdjustPlayerCameraType CameraConfig;
	}
}
