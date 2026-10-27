using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006531 RID: 25905
	public sealed class CrossClearComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x06040F16 RID: 266006 RVA: 0x00FBCB88 File Offset: 0x00FBAD88
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			sink.MarkCrossClearPresentation(pos);
			sink.MarkDetonationPresentation(pos);
			for (int i = 0; i < 8; i++)
			{
				sink.RequestClear(new GridPosition(pos.Row, i), Math.Abs(i - pos.Col) * 55, EPieceClearReason.SplashedByCross, new GridPosition?(pos));
			}
			for (int j = 0; j < 7; j++)
			{
				sink.RequestClear(new GridPosition(j, pos.Col), Math.Abs(j - pos.Row) * 55, EPieceClearReason.SplashedByCross, new GridPosition?(pos));
			}
		}
	}
}
