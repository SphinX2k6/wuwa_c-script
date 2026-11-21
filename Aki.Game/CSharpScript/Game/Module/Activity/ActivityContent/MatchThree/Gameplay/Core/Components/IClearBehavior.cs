using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B7 RID: 21687
	[NullableContext(1)]
	public interface IClearBehavior
	{
		// Token: 0x06035BF7 RID: 220151
		void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source);
	}
}
