using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005485 RID: 21637
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceMoveEvent
	{
		// Token: 0x06035B61 RID: 220001 RVA: 0x00F025B1 File Offset: 0x00F007B1
		public PieceMoveEvent(int fromCol, int toCol, int fromRow, int toRow, Piece piece)
		{
			this.FromCol = fromCol;
			this.ToCol = toCol;
			this.FromRow = fromRow;
			this.ToRow = toRow;
			this.Piece = piece;
		}

		// Token: 0x0401C6A3 RID: 116387
		public int FromCol;

		// Token: 0x0401C6A4 RID: 116388
		public int ToCol;

		// Token: 0x0401C6A5 RID: 116389
		public int FromRow;

		// Token: 0x0401C6A6 RID: 116390
		public int ToRow;

		// Token: 0x0401C6A7 RID: 116391
		public Piece Piece;
	}
}
