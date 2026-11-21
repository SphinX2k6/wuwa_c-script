using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B8 RID: 21688
	[NullableContext(1)]
	public interface ILandBehavior
	{
		// Token: 0x06035BF8 RID: 220152
		void OnLandedBottom(IDispatchContext sink, Piece self, GridPosition pos);
	}
}
