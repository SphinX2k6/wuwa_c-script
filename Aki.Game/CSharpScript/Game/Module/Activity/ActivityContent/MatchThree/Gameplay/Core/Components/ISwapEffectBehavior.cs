using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B9 RID: 21689
	[NullableContext(1)]
	public interface ISwapEffectBehavior
	{
		// Token: 0x06035BF9 RID: 220153
		bool CanSwapWith(Piece other);

		// Token: 0x06035BFA RID: 220154
		void OnSwapped(IDispatchContext sink, Piece self, GridPosition selfPos, Piece other, GridPosition otherPos);
	}
}
