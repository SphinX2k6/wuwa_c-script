using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B6 RID: 21686
	[NullableContext(1)]
	public interface IDispatchContext
	{
		// Token: 0x17006893 RID: 26771
		// (get) Token: 0x06035BEB RID: 220139
		Board Board { get; }

		// Token: 0x06035BEC RID: 220140
		void RequestClear(GridPosition pos, int delayMs = 0, EPieceClearReason reason = EPieceClearReason.Matched, GridPosition? detonationSource = null);

		// Token: 0x06035BED RID: 220141
		void MarkDetonationPresentation(GridPosition pos);

		// Token: 0x06035BEE RID: 220142
		void MarkCrossClearPresentation(GridPosition pos);

		// Token: 0x06035BEF RID: 220143
		void RequestUltimateStrike(GridPosition origin, GridPosition target, EPieceClearReason reason);

		// Token: 0x06035BF0 RID: 220144
		void RemovePiece(GridPosition pos);

		// Token: 0x06035BF1 RID: 220145
		int NextRandom(int maxExclusive);

		// Token: 0x17006894 RID: 26772
		// (get) Token: 0x06035BF2 RID: 220146
		[Nullable(2)]
		EliminateRule CurrentClearRule { [NullableContext(2)] get; }

		// Token: 0x06035BF3 RID: 220147
		void AddScore(int amount);

		// Token: 0x06035BF4 RID: 220148
		void AddCharge(int amount);

		// Token: 0x06035BF5 RID: 220149
		void AddTurns(int amount);

		// Token: 0x06035BF6 RID: 220150
		void EmitEnergyTrail(int energy);
	}
}
