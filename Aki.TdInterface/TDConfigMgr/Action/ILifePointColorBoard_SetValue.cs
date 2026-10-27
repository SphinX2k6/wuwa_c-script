using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7D RID: 7037
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePointColorBoard_SetValue
	{
		// Token: 0x04005C1D RID: 23581
		public List<IColorPiece> Config;

		// Token: 0x04005C1E RID: 23582
		public List<EPieceColorType> Colors;

		// Token: 0x04005C1F RID: 23583
		public EPieceColorType TargetColor;
	}
}
