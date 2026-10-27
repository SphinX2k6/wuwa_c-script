using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006512 RID: 25874
	[NullableContext(1)]
	[Nullable(0)]
	public struct SkillTrailEvent
	{
		// Token: 0x06040EA4 RID: 265892 RVA: 0x00FBB714 File Offset: 0x00FB9914
		public SkillTrailEvent(GridPosition target, ESkillTrailType type, Piece piece)
		{
			this.Target = target;
			this.Type = type;
			this.Piece = piece;
		}

		// Token: 0x04021DAE RID: 138670
		public GridPosition Target;

		// Token: 0x04021DAF RID: 138671
		public ESkillTrailType Type;

		// Token: 0x04021DB0 RID: 138672
		public Piece Piece;
	}
}
