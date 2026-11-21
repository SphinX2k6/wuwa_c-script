using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005489 RID: 21641
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceAttachEvent
	{
		// Token: 0x06035B65 RID: 220005 RVA: 0x00F0269A File Offset: 0x00F0089A
		public PieceAttachEvent(GridPosition pos, Piece piece)
		{
			this.Pos = pos;
			this.Piece = piece;
		}

		// Token: 0x0401C6BE RID: 116414
		public GridPosition Pos;

		// Token: 0x0401C6BF RID: 116415
		public Piece Piece;
	}
}
