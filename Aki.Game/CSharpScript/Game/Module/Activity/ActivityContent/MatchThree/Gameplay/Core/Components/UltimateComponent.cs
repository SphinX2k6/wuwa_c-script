using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200653F RID: 25919
	public sealed class UltimateComponent : IPieceComponent, ISwapEffectBehavior, IClearBehavior
	{
		// Token: 0x17009534 RID: 38196
		// (get) Token: 0x06040F3C RID: 266044 RVA: 0x00FBCF7A File Offset: 0x00FBB17A
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.SwapEffect;
			}
		}

		// Token: 0x06040F3D RID: 266045 RVA: 0x00FBCF81 File Offset: 0x00FBB181
		[NullableContext(1)]
		public bool CanSwapWith(Piece other)
		{
			return other.Type == EPieceType.Ultimate || MatchThreeGameplayDefine.NormalPieceTypes.Contains(other.Type);
		}

		// Token: 0x06040F3E RID: 266046 RVA: 0x00FBCFA0 File Offset: 0x00FBB1A0
		[NullableContext(1)]
		public void OnSwapped(IDispatchContext sink, Piece self, GridPosition selfPos, Piece other, GridPosition otherPos)
		{
			if (other.Type == EPieceType.Ultimate)
			{
				sink.RequestClear(selfPos, 0, EPieceClearReason.UltimateAllManual, null);
				sink.RequestClear(otherPos, 0, EPieceClearReason.UltimateAllPassive, null);
				for (int i = 0; i < 7; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						Piece piece = sink.Board.GetPiece(i, j);
						if (piece == null || piece.Type != EPieceType.Ultimate)
						{
							sink.RequestClear(new GridPosition(i, j), 0, EPieceClearReason.ClearSelf, null);
						}
					}
				}
				return;
			}
			sink.RequestClear(selfPos, 0, EPieceClearReason.ClearSelf, null);
			UltimateComponent.ClearAllOfType(sink, other.Type, selfPos);
		}

		// Token: 0x06040F3F RID: 266047 RVA: 0x00FBD04B File Offset: 0x00FBB24B
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			if (source == null)
			{
				return;
			}
			UltimateComponent.ClearAllOfType(sink, source.Value, pos);
		}

		// Token: 0x06040F40 RID: 266048 RVA: 0x00FBD068 File Offset: 0x00FBB268
		[NullableContext(1)]
		private static void ClearAllOfType(IDispatchContext sink, EPieceType targetType, GridPosition origin)
		{
			Board board = sink.Board;
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Piece piece = board.GetPiece(i, j);
					if (piece != null && piece.Type == targetType)
					{
						sink.RequestUltimateStrike(origin, new GridPosition(i, j), EPieceClearReason.ClearSelf);
					}
				}
			}
		}
	}
}
