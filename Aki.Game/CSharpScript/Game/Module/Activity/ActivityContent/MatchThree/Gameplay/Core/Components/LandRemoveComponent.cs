using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B2 RID: 21682
	public sealed class LandRemoveComponent : IPieceComponent, ILandBehavior
	{
		// Token: 0x17006890 RID: 26768
		// (get) Token: 0x06035BE2 RID: 220130 RVA: 0x00F03C88 File Offset: 0x00F01E88
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Land;
			}
		}

		// Token: 0x06035BE3 RID: 220131 RVA: 0x00F03C8C File Offset: 0x00F01E8C
		[NullableContext(1)]
		public void OnLandedBottom(IDispatchContext sink, Piece self, GridPosition pos)
		{
			sink.RemovePiece(pos);
		}
	}
}
