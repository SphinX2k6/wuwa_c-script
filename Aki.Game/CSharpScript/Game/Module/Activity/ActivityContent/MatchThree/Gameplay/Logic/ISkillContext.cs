using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005479 RID: 21625
	[NullableContext(1)]
	public interface ISkillContext
	{
		// Token: 0x06035B2F RID: 219951
		void ApplyAllureSmallRecolor(int skillId);

		// Token: 0x06035B30 RID: 219952
		void ApplyAllureUltimateRecolor(int skillId, IReadOnlyList<int> sourceRanks, int targetRank);

		// Token: 0x06035B31 RID: 219953
		IReadOnlyList<GridPosition> PickChainCells(int count, out bool anyEffectCarrier);

		// Token: 0x06035B32 RID: 219954
		void AttachChain(GridPosition pos, int[] chainExtra, bool withBomb, bool withTrail);

		// Token: 0x06035B33 RID: 219955
		int NextRandom(int maxExclusive);
	}
}
