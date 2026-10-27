using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006519 RID: 25881
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class BoardSegment
	{
		// Token: 0x1700951B RID: 38171
		// (get) Token: 0x06040EAD RID: 265901 RVA: 0x00FBB7D5 File Offset: 0x00FB99D5
		public bool IsEmpty
		{
			get
			{
				return this.Clears.Count == 0 && this.Hits.Count == 0 && this.Moves.Count == 0;
			}
		}

		// Token: 0x06040EAE RID: 265902 RVA: 0x00FBB801 File Offset: 0x00FB9A01
		public void Clear()
		{
			this.Clears.Clear();
			this.Hits.Clear();
			this.Moves.Clear();
		}

		// Token: 0x04021DC2 RID: 138690
		public readonly List<PieceClearEvent> Clears = new List<PieceClearEvent>();

		// Token: 0x04021DC3 RID: 138691
		public readonly List<PieceHitEvent> Hits = new List<PieceHitEvent>();

		// Token: 0x04021DC4 RID: 138692
		public readonly List<PieceMoveEvent> Moves = new List<PieceMoveEvent>();
	}
}
