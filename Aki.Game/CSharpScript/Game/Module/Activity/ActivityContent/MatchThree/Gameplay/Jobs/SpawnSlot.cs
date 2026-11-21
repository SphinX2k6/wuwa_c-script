using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005486 RID: 21638
	[NullableContext(2)]
	[Nullable(0)]
	public struct SpawnSlot
	{
		// Token: 0x06035B62 RID: 220002 RVA: 0x00F025D8 File Offset: 0x00F007D8
		public SpawnSlot(GridPosition pos, EPieceType type, int[] extra)
		{
			this.Pos = pos;
			this.Type = type;
			this.Extra = extra;
			this.Piece = null;
		}

		// Token: 0x0401C6A8 RID: 116392
		public GridPosition Pos;

		// Token: 0x0401C6A9 RID: 116393
		public EPieceType Type;

		// Token: 0x0401C6AA RID: 116394
		public int[] Extra;

		// Token: 0x0401C6AB RID: 116395
		public Piece Piece;
	}
}
