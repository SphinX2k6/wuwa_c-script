using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200653A RID: 25914
	[NullableContext(1)]
	public interface ILandBehavior
	{
		// Token: 0x06040F33 RID: 266035
		void OnLandedBottom(IDispatchContext sink, Piece self, GridPosition pos);
	}
}
