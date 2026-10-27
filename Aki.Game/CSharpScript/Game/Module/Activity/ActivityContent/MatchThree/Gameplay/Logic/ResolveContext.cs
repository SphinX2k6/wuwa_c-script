using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F4 RID: 25844
	[NullableContext(1)]
	[Nullable(0)]
	public class ResolveContext
	{
		// Token: 0x04021D15 RID: 138517
		public readonly SolvedData Solved = new SolvedData();

		// Token: 0x04021D16 RID: 138518
		public EResolvePhase Phase;

		// Token: 0x04021D17 RID: 138519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IJob> FirstSegment;

		// Token: 0x04021D18 RID: 138520
		public int EliminationSegments;

		// Token: 0x04021D19 RID: 138521
		public int CascadeSegments;

		// Token: 0x04021D1A RID: 138522
		public bool IsPlayerTurn;

		// Token: 0x04021D1B RID: 138523
		public bool TurnSettled;

		// Token: 0x04021D1C RID: 138524
		public bool MechanicsResolved;

		// Token: 0x04021D1D RID: 138525
		public readonly List<int> PendingLandedCols = new List<int>();

		// Token: 0x04021D1E RID: 138526
		public EResolvePhase LandReturnPhase = EResolvePhase.Skill;
	}
}
