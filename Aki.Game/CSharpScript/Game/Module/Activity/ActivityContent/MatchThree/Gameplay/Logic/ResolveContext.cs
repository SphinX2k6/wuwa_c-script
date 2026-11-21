using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005472 RID: 21618
	[NullableContext(1)]
	[Nullable(0)]
	public class ResolveContext
	{
		// Token: 0x0401C646 RID: 116294
		public readonly SolvedData Solved = new SolvedData();

		// Token: 0x0401C647 RID: 116295
		public EResolvePhase Phase;

		// Token: 0x0401C648 RID: 116296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> FirstSegment;

		// Token: 0x0401C649 RID: 116297
		public int EliminationSegments;

		// Token: 0x0401C64A RID: 116298
		public int CascadeSegments;

		// Token: 0x0401C64B RID: 116299
		public bool IsPlayerTurn;

		// Token: 0x0401C64C RID: 116300
		public bool TurnSettled;

		// Token: 0x0401C64D RID: 116301
		public bool MechanicsResolved;

		// Token: 0x0401C64E RID: 116302
		public readonly List<int> PendingLandedCols = new List<int>();

		// Token: 0x0401C64F RID: 116303
		public EResolvePhase LandReturnPhase = EResolvePhase.Skill;
	}
}
