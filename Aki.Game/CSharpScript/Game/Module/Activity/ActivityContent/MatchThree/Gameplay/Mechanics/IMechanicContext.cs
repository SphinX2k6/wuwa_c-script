using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x02005469 RID: 21609
	[NullableContext(2)]
	public interface IMechanicContext
	{
		// Token: 0x06035A5B RID: 219739
		[NullableContext(1)]
		IReadOnlyList<GridPosition> PickGenerateCells(int count, IReadOnlyList<CellZone> zones);

		// Token: 0x06035A5C RID: 219740
		int GetRecycleClearCount(EPieceType type);

		// Token: 0x06035A5D RID: 219741
		void TransformPiece(int envId, GridPosition pos, EPieceType type, int[] extra = null);

		// Token: 0x06035A5E RID: 219742
		void ShowTip(string textId, int remainingRounds, int generateCount);
	}
}
