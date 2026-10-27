using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200470F RID: 18191
	[NullableContext(1)]
	public interface IWuWaGoWorldMoveDriverOptions
	{
		// Token: 0x170076CA RID: 30410
		// (get) Token: 0x0602F89D RID: 194717
		IReadOnlyList<IWuWaGoWorldMoveTarget> Targets { get; }

		// Token: 0x170076CB RID: 30411
		// (get) Token: 0x0602F89E RID: 194718
		Vector FromWorldPosition { get; }

		// Token: 0x170076CC RID: 30412
		// (get) Token: 0x0602F89F RID: 194719
		Vector ToWorldPosition { get; }

		// Token: 0x170076CD RID: 30413
		// (get) Token: 0x0602F8A0 RID: 194720
		int? DurationMs { get; }

		// Token: 0x170076CE RID: 30414
		// (get) Token: 0x0602F8A1 RID: 194721
		float? Speed { get; }

		// Token: 0x170076CF RID: 30415
		// (get) Token: 0x0602F8A2 RID: 194722
		int? TimeoutMs { get; }

		// Token: 0x170076D0 RID: 30416
		// (get) Token: 0x0602F8A3 RID: 194723
		int? TickIntervalMs { get; }

		// Token: 0x170076D1 RID: 30417
		// (get) Token: 0x0602F8A4 RID: 194724
		int? SettleDurationMs { get; }

		// Token: 0x170076D2 RID: 30418
		// (get) Token: 0x0602F8A5 RID: 194725
		float? EarlyStopStepRatio { get; }

		// Token: 0x170076D3 RID: 30419
		// (get) Token: 0x0602F8A6 RID: 194726
		float? ArriveTolerance { get; }

		// Token: 0x170076D4 RID: 30420
		// (get) Token: 0x0602F8A7 RID: 194727
		[Nullable(2)]
		Func<bool> ShouldAbort { [NullableContext(2)] get; }

		// Token: 0x170076D5 RID: 30421
		// (get) Token: 0x0602F8A8 RID: 194728
		EWuWaGoTimeStopPolicy? TimeStopPolicy { get; }

		// Token: 0x170076D6 RID: 30422
		// (get) Token: 0x0602F8A9 RID: 194729
		[Nullable(2)]
		IWuWaGoWorldMoveHooks Hooks { [NullableContext(2)] get; }
	}
}
