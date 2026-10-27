using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006507 RID: 25863
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceMoveEvent
	{
		// Token: 0x06040E9D RID: 265885 RVA: 0x00FBB581 File Offset: 0x00FB9781
		public PieceMoveEvent(int fromCol, int toCol, int fromRow, int toRow, Piece piece)
		{
			this.FromCol = fromCol;
			this.ToCol = toCol;
			this.FromRow = fromRow;
			this.ToRow = toRow;
			this.Piece = piece;
		}

		// Token: 0x04021D72 RID: 138610
		public int FromCol;

		// Token: 0x04021D73 RID: 138611
		public int ToCol;

		// Token: 0x04021D74 RID: 138612
		public int FromRow;

		// Token: 0x04021D75 RID: 138613
		public int ToRow;

		// Token: 0x04021D76 RID: 138614
		public Piece Piece;
	}
}
