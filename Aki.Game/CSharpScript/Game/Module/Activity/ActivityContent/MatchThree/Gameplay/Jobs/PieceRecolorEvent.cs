using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200650D RID: 25869
	[NullableContext(1)]
	[Nullable(0)]
	public struct PieceRecolorEvent
	{
		// Token: 0x06040EA2 RID: 265890 RVA: 0x00FBB67A File Offset: 0x00FB987A
		public PieceRecolorEvent(GridPosition pos, EPieceType fromType, EPieceType toType, Piece piece, ESkillRecolorPresentation presentation)
		{
			this.Pos = pos;
			this.FromType = fromType;
			this.ToType = toType;
			this.Piece = piece;
			this.Presentation = presentation;
		}

		// Token: 0x04021D92 RID: 138642
		public GridPosition Pos;

		// Token: 0x04021D93 RID: 138643
		public EPieceType FromType;

		// Token: 0x04021D94 RID: 138644
		public EPieceType ToType;

		// Token: 0x04021D95 RID: 138645
		public Piece Piece;

		// Token: 0x04021D96 RID: 138646
		public ESkillRecolorPresentation Presentation;
	}
}
