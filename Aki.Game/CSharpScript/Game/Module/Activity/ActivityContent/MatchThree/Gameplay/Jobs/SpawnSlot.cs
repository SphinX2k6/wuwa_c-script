using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006508 RID: 25864
	[NullableContext(2)]
	[Nullable(0)]
	public struct SpawnSlot
	{
		// Token: 0x06040E9E RID: 265886 RVA: 0x00FBB5A8 File Offset: 0x00FB97A8
		public SpawnSlot(GridPosition pos, EPieceType type, int[] extra)
		{
			this.Pos = pos;
			this.Type = type;
			this.Extra = extra;
			this.Piece = null;
		}

		// Token: 0x04021D77 RID: 138615
		public GridPosition Pos;

		// Token: 0x04021D78 RID: 138616
		public EPieceType Type;

		// Token: 0x04021D79 RID: 138617
		public int[] Extra;

		// Token: 0x04021D7A RID: 138618
		public Piece Piece;
	}
}
