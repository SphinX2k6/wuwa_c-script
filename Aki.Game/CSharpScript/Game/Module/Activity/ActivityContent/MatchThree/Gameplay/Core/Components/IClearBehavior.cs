using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006539 RID: 25913
	[NullableContext(1)]
	public interface IClearBehavior
	{
		// Token: 0x06040F32 RID: 266034
		void OnCleared(IDispatchContext sink, Piece self, GridPosition pos, EPieceType? source);
	}
}
