using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200653E RID: 25918
	public sealed class TurnGainComponent : IClearBehavior, IPieceComponent
	{
		// Token: 0x06040F3A RID: 266042 RVA: 0x00FBCF53 File Offset: 0x00FBB153
		public TurnGainComponent(int gainTurns)
		{
		}

		// Token: 0x06040F3B RID: 266043 RVA: 0x00FBCF62 File Offset: 0x00FBB162
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			if (this.<gainTurns>P <= 0)
			{
				return;
			}
			sink.AddTurns(this.<gainTurns>P);
		}

		// Token: 0x04021E0B RID: 138763
		[CompilerGenerated]
		private int <gainTurns>P = gainTurns;
	}
}
