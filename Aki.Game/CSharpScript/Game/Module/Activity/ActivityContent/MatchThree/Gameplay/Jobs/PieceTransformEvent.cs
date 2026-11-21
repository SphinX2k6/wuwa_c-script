using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005488 RID: 21640
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceTransformEvent
	{
		// Token: 0x06035B64 RID: 220004 RVA: 0x00F02683 File Offset: 0x00F00883
		public PieceTransformEvent(GridPosition pos, EPieceType type, Piece piece)
		{
			this.Pos = pos;
			this.Type = type;
			this.Piece = piece;
		}

		// Token: 0x0401C6BB RID: 116411
		public GridPosition Pos;

		// Token: 0x0401C6BC RID: 116412
		public EPieceType Type;

		// Token: 0x0401C6BD RID: 116413
		public Piece Piece;
	}
}
