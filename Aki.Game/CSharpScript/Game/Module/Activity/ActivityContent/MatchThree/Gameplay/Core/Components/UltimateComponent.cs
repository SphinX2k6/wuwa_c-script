using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054BD RID: 21693
	public sealed class UltimateComponent : IPieceComponent, ISwapEffectBehavior, IClearBehavior
	{
		// Token: 0x17006896 RID: 26774
		// (get) Token: 0x06035C01 RID: 220161 RVA: 0x00F03FBE File Offset: 0x00F021BE
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.SwapEffect;
			}
		}

		// Token: 0x06035C02 RID: 220162 RVA: 0x00F03FC5 File Offset: 0x00F021C5
		[NullableContext(1)]
		public bool CanSwapWith(Piece other)
		{
			return other.Type == EPieceType.Ultimate || MatchThreeGameplayDefine.NormalPieceTypes.Contains(other.Type);
		}

		// Token: 0x06035C03 RID: 220163 RVA: 0x00F03FE4 File Offset: 0x00F021E4
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

		// Token: 0x06035C04 RID: 220164 RVA: 0x00F0408F File Offset: 0x00F0228F
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			if (source == null)
			{
				return;
			}
			UltimateComponent.ClearAllOfType(sink, source.Value, pos);
		}

		// Token: 0x06035C05 RID: 220165 RVA: 0x00F040AC File Offset: 0x00F022AC
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
