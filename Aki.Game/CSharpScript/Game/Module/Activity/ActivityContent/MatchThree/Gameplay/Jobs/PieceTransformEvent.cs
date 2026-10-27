using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200650A RID: 25866
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceTransformEvent
	{
		// Token: 0x06040EA0 RID: 265888 RVA: 0x00FBB653 File Offset: 0x00FB9853
		public PieceTransformEvent(GridPosition pos, EPieceType type, Piece piece)
		{
			this.Pos = pos;
			this.Type = type;
			this.Piece = piece;
		}

		// Token: 0x04021D8A RID: 138634
		public GridPosition Pos;

		// Token: 0x04021D8B RID: 138635
		public EPieceType Type;

		// Token: 0x04021D8C RID: 138636
		public Piece Piece;
	}
}
