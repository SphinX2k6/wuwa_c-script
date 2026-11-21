using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B3 RID: 21683
	public sealed class MatchableComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x17006891 RID: 26769
		// (get) Token: 0x06035BE5 RID: 220133 RVA: 0x00F03C9D File Offset: 0x00F01E9D
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Matchable;
			}
		}

		// Token: 0x06035BE6 RID: 220134 RVA: 0x00F03CA4 File Offset: 0x00F01EA4
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			EliminateRule currentClearRule = sink.CurrentClearRule;
			if (currentClearRule != null)
			{
				sink.AddScore(currentClearRule.PieceScore);
				MatchableComponent.Charge(sink, currentClearRule.PieceEnergy);
				return;
			}
			ValueTuple<int, int> pieceGain = sink.Board.GetPieceGain(self.Type);
			int item = pieceGain.Item1;
			int item2 = pieceGain.Item2;
			sink.AddScore(item2);
			MatchableComponent.Charge(sink, item);
		}

		// Token: 0x06035BE7 RID: 220135 RVA: 0x00F03D00 File Offset: 0x00F01F00
		[NullableContext(1)]
		private static void Charge(IDispatchContext sink, int energy)
		{
			sink.AddCharge(energy);
			if (energy > 0)
			{
				sink.EmitEnergyTrail(energy);
			}
		}
	}
}
