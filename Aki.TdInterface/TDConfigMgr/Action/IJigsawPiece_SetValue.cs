using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6B RID: 7019
	public class IJigsawPiece_SetValue
	{
		// Token: 0x04005BEF RID: 23535
		[Nullable(1)]
		public IPieceIndex Index;

		// Token: 0x04005BF0 RID: 23536
		public bool Active;

		// Token: 0x04005BF1 RID: 23537
		public bool IsCorrect;

		// Token: 0x04005BF2 RID: 23538
		public EJigsawPieceState InitState;
	}
}
