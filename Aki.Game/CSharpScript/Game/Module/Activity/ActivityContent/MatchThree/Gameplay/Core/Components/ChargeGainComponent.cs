using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054AD RID: 21677
	public sealed class ChargeGainComponent : IPieceComponent, IClearBehavior
	{
		// Token: 0x06035BD7 RID: 220119 RVA: 0x00F03B89 File Offset: 0x00F01D89
		public ChargeGainComponent(int gainEnergy)
		{
		}

		// Token: 0x06035BD8 RID: 220120 RVA: 0x00F03B98 File Offset: 0x00F01D98
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

		// Token: 0x0401C72E RID: 116526
		[CompilerGenerated]
		private int <gainEnergy>P = gainEnergy;
	}
}
