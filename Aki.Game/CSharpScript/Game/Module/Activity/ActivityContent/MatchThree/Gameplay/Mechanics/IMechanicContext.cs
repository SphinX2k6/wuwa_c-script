using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064EB RID: 25835
	[NullableContext(2)]
	public interface IMechanicContext
	{
		// Token: 0x06040D97 RID: 265623
		[NullableContext(1)]
		IReadOnlyList<GridPosition> PickGenerateCells(int count, IReadOnlyList<CellZone> zones);

		// Token: 0x06040D98 RID: 265624
		int GetRecycleClearCount(EPieceType type);

		// Token: 0x06040D99 RID: 265625
		void TransformPiece(int envId, GridPosition pos, EPieceType type, int[] extra = null);

		// Token: 0x06040D9A RID: 265626
		void ShowTip(string textId, int remainingRounds, int generateCount);
	}
}
