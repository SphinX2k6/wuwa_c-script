using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200650B RID: 25867
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceAttachEvent
	{
		// Token: 0x06040EA1 RID: 265889 RVA: 0x00FBB66A File Offset: 0x00FB986A
		public PieceAttachEvent(GridPosition pos, Piece piece)
		{
			this.Pos = pos;
			this.Piece = piece;
		}

		// Token: 0x04021D8D RID: 138637
		public GridPosition Pos;

		// Token: 0x04021D8E RID: 138638
		public Piece Piece;
	}
}
