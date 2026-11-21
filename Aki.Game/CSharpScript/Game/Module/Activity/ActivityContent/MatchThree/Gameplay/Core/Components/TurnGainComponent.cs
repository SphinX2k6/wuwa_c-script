using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054BC RID: 21692
	public sealed class TurnGainComponent : IClearBehavior, IPieceComponent
	{
		// Token: 0x06035BFF RID: 220159 RVA: 0x00F03F97 File Offset: 0x00F02197
		public TurnGainComponent(int gainTurns)
		{
		}

		// Token: 0x06035C00 RID: 220160 RVA: 0x00F03FA6 File Offset: 0x00F021A6
		[NullableContext(1)]
		public void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source)
		{
			if (this.<gainTurns>P <= 0)
			{
				return;
			}
			sink.AddTurns(this.<gainTurns>P);
		}

		// Token: 0x0401C73C RID: 116540
		[CompilerGenerated]
		private int <gainTurns>P = gainTurns;
	}
}
