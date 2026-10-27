using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056C1 RID: 22209
	[NullableContext(1)]
	[Nullable(0)]
	public class CloseLoadingProcess : PendingProcess<EProcessType>
	{
		// Token: 0x060387D9 RID: 231385 RVA: 0x00D6B234 File Offset: 0x00D69434
		public CloseLoadingProcess(ELoadingReason reason, Action callback, float? duration = null, [Nullable(2)] string context = null) : base(EProcessType.CloseLoading)
		{
			this.Reason = reason;
			this.Callback = callback;
			this.Duration = duration.GetValueOrDefault(1f);
			this.Context = context;
		}

		// Token: 0x0401DAB5 RID: 121525
		public ELoadingReason Reason;

		// Token: 0x0401DAB6 RID: 121526
		public Action Callback;

		// Token: 0x0401DAB7 RID: 121527
		public float Duration;

		// Token: 0x0401DAB8 RID: 121528
		[Nullable(2)]
		public string Context;
	}
}
