using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006535 RID: 25909
	public sealed class MatchableComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x1700952F RID: 38191
		// (get) Token: 0x06040F20 RID: 266016 RVA: 0x00FBCC59 File Offset: 0x00FBAE59
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Matchable;
			}
		}

		// Token: 0x06040F21 RID: 266017 RVA: 0x00FBCC60 File Offset: 0x00FBAE60
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

		// Token: 0x06040F22 RID: 266018 RVA: 0x00FBCCBC File Offset: 0x00FBAEBC
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
