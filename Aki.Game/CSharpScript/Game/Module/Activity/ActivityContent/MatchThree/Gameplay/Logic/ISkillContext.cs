using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064FB RID: 25851
	[NullableContext(1)]
	public interface ISkillContext
	{
		// Token: 0x06040E6B RID: 265835
		void ApplyAllureSmallRecolor(int skillId);

		// Token: 0x06040E6C RID: 265836
		void ApplyAllureUltimateRecolor(int skillId, IReadOnlyList<int> sourceRanks, int targetRank);

		// Token: 0x06040E6D RID: 265837
		IReadOnlyList<GridPosition> PickChainCells(int count, out bool anyEffectCarrier);

		// Token: 0x06040E6E RID: 265838
		void AttachChain(GridPosition pos, int[] chainExtra, bool withBomb, bool withTrail);

		// Token: 0x06040E6F RID: 265839
		int NextRandom(int maxExclusive);
	}
}
