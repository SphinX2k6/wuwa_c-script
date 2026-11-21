using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200363F RID: 13887
	[NullableContext(1)]
	public interface IWuWaGoWorldMoveDriverOptions
	{
		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x06024063 RID: 147555
		IReadOnlyList<IWuWaGoWorldMoveTarget> Targets { get; }

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x06024064 RID: 147556
		Vector FromWorldPosition { get; }

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x06024065 RID: 147557
		Vector ToWorldPosition { get; }

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x06024066 RID: 147558
		int? DurationMs { get; }

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x06024067 RID: 147559
		float? Speed { get; }

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x06024068 RID: 147560
		int? TimeoutMs { get; }

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x06024069 RID: 147561
		int? TickIntervalMs { get; }

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x0602406A RID: 147562
		int? SettleDurationMs { get; }

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x0602406B RID: 147563
		float? EarlyStopStepRatio { get; }

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x0602406C RID: 147564
		float? ArriveTolerance { get; }

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x0602406D RID: 147565
		[Nullable(2)]
		Func<bool> ShouldAbort { [NullableContext(2)] get; }

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x0602406E RID: 147566
		EWuWaGoTimeStopPolicy? TimeStopPolicy { get; }

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x0602406F RID: 147567
		[Nullable(2)]
		IWuWaGoWorldMoveHooks Hooks { [NullableContext(2)] get; }
	}
}
