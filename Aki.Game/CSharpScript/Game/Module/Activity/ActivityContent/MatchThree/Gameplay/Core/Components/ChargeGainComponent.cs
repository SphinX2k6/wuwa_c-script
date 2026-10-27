using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200652F RID: 25903
	public sealed class ChargeGainComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x06040F12 RID: 266002 RVA: 0x00FBCB45 File Offset: 0x00FBAD45
		public ChargeGainComponent(int gainEnergy)
		{
		}

		// Token: 0x06040F13 RID: 266003 RVA: 0x00FBCB54 File Offset: 0x00FBAD54
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			if (this.<gainEnergy>P <= 0)
			{
				return;
			}
			sink.AddCharge(this.<gainEnergy>P);
			sink.EmitEnergyTrail(this.<gainEnergy>P);
		}

		// Token: 0x04021DFD RID: 138749
		[CompilerGenerated]
		private int <gainEnergy>P = gainEnergy;
	}
}
