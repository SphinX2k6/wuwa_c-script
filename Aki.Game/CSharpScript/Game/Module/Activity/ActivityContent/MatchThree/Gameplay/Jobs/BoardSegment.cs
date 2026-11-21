using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005497 RID: 21655
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class BoardSegment
	{
		// Token: 0x1700687D RID: 26749
		// (get) Token: 0x06035B71 RID: 220017 RVA: 0x00F02805 File Offset: 0x00F00A05
		public bool IsEmpty
		{
			get
			{
				return this.Clears.Count == 0 && this.Hits.Count == 0 && this.Moves.Count == 0;
			}
		}

		// Token: 0x06035B72 RID: 220018 RVA: 0x00F02831 File Offset: 0x00F00A31
		public void Clear()
		{
			this.Clears.Clear();
			this.Hits.Clear();
			this.Moves.Clear();
		}

		// Token: 0x0401C6F3 RID: 116467
		public readonly List<PieceClearEvent> Clears = new List<PieceClearEvent>();

		// Token: 0x0401C6F4 RID: 116468
		public readonly List<PieceHitEvent> Hits = new List<PieceHitEvent>();

		// Token: 0x0401C6F5 RID: 116469
		public readonly List<PieceMoveEvent> Moves = new List<PieceMoveEvent>();
	}
}
