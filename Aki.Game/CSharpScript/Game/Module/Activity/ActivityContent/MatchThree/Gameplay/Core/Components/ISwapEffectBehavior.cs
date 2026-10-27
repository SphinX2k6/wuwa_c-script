using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200653B RID: 25915
	[NullableContext(1)]
	public interface ISwapEffectBehavior
	{
		// Token: 0x06040F34 RID: 266036
		bool CanSwapWith(Piece other);

		// Token: 0x06040F35 RID: 266037
		void OnSwapped(IDispatchContext sink, Piece self, GridPosition selfPos, Piece other, GridPosition otherPos);
	}
}
