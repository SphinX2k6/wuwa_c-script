using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005490 RID: 21648
	[NullableContext(1)]
	[Nullable(0)]
	public struct SkillTrailEvent
	{
		// Token: 0x06035B68 RID: 220008 RVA: 0x00F02744 File Offset: 0x00F00944
		public SkillTrailEvent(GridPosition target, ESkillTrailType type, Piece piece)
		{
			this.Target = target;
			this.Type = type;
			this.Piece = piece;
		}

		// Token: 0x0401C6DF RID: 116447
		public GridPosition Target;

		// Token: 0x0401C6E0 RID: 116448
		public ESkillTrailType Type;

		// Token: 0x0401C6E1 RID: 116449
		public Piece Piece;
	}
}
