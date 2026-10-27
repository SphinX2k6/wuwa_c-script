using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006538 RID: 25912
	[NullableContext(1)]
	public interface IDispatchContext
	{
		// Token: 0x17009531 RID: 38193
		// (get) Token: 0x06040F26 RID: 266022
		Board Board { get; }

		// Token: 0x06040F27 RID: 266023
		void RequestClear(GridPosition pos, int delayMs = 0, EPieceClearReason reason = EPieceClearReason.Matched, GridPosition? detonationSource = null);

		// Token: 0x06040F28 RID: 266024
		void MarkDetonationPresentation(GridPosition pos);

		// Token: 0x06040F29 RID: 266025
		void MarkCrossClearPresentation(GridPosition pos);

		// Token: 0x06040F2A RID: 266026
		void RequestUltimateStrike(GridPosition origin, GridPosition target, EPieceClearReason reason);

		// Token: 0x06040F2B RID: 266027
		void RemovePiece(GridPosition pos);

		// Token: 0x06040F2C RID: 266028
		int NextRandom(int maxExclusive);

		// Token: 0x17009532 RID: 38194
		// (get) Token: 0x06040F2D RID: 266029
		[Nullable(2)]
		EliminateRule CurrentClearRule { [NullableContext(2)] get; }

		// Token: 0x06040F2E RID: 266030
		void AddScore(int amount);

		// Token: 0x06040F2F RID: 266031
		void AddCharge(int amount);

		// Token: 0x06040F30 RID: 266032
		void AddTurns(int amount);

		// Token: 0x06040F31 RID: 266033
		void EmitEnergyTrail(int energy);
	}
}
