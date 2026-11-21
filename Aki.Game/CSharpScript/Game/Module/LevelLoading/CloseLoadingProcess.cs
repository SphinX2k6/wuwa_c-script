using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x02004698 RID: 18072
	[NullableContext(1)]
	[Nullable(0)]
	public class CloseLoadingProcess : PendingProcess<EProcessType>
	{
		// Token: 0x0602D6E0 RID: 186080 RVA: 0x00CB937C File Offset: 0x00CB757C
		public CloseLoadingProcess(ELoadingReason reason, Action callback, float? duration = null, [Nullable(2)] string context = null) : base(EProcessType.CloseLoading)
		{
			this.Reason = reason;
			this.Callback = callback;
			this.Duration = duration.GetValueOrDefault(1f);
			this.Context = context;
		}

		// Token: 0x04018542 RID: 99650
		public ELoadingReason Reason;

		// Token: 0x04018543 RID: 99651
		public Action Callback;

		// Token: 0x04018544 RID: 99652
		public float Duration;

		// Token: 0x04018545 RID: 99653
		[Nullable(2)]
		public string Context;
	}
}
