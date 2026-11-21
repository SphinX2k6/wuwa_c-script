using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200548B RID: 21643
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceRecolorEvent
	{
		// Token: 0x06035B66 RID: 220006 RVA: 0x00F026AA File Offset: 0x00F008AA
		public PieceRecolorEvent(GridPosition pos, EPieceType fromType, EPieceType toType, Piece piece, ESkillRecolorPresentation presentation)
		{
			this.Pos = pos;
			this.FromType = fromType;
			this.ToType = toType;
			this.Piece = piece;
			this.Presentation = presentation;
		}

		// Token: 0x0401C6C3 RID: 116419
		public GridPosition Pos;

		// Token: 0x0401C6C4 RID: 116420
		public EPieceType FromType;

		// Token: 0x0401C6C5 RID: 116421
		public EPieceType ToType;

		// Token: 0x0401C6C6 RID: 116422
		public Piece Piece;

		// Token: 0x0401C6C7 RID: 116423
		public ESkillRecolorPresentation Presentation;
	}
}
