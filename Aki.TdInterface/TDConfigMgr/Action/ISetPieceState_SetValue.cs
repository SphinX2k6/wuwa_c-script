using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3D RID: 7741
	public class ISetPieceState_SetValue
	{
		// Token: 0x0400630A RID: 25354
		public ESetJigsawFoundationType Type;

		// Token: 0x0400630B RID: 25355
		public int EntityId;

		// Token: 0x0400630C RID: 25356
		[Nullable(1)]
		public List<IJigsawPiece> PieceState;
	}
}
