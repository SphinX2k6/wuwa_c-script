using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.StepSequence
{
	// Token: 0x02004526 RID: 17702
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceContext
	{
		// Token: 0x0602DBA4 RID: 187300 RVA: 0x00A82102 File Offset: 0x00A80302
		public SequenceContext(ISequenceAbortSignal abortSignal)
		{
			this.AbortSignal = abortSignal;
		}

		// Token: 0x0602DBA5 RID: 187301 RVA: 0x00A82114 File Offset: 0x00A80314
		public void Stop()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "StepSequence:请求提前结束(Stop)", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StopRequested = true;
		}

		// Token: 0x17007511 RID: 29969
		// (get) Token: 0x0602DBA6 RID: 187302 RVA: 0x00A82144 File Offset: 0x00A80344
		public bool IsStopRequested
		{
			get
			{
				return this.StopRequested;
			}
		}

		// Token: 0x0602DBA7 RID: 187303 RVA: 0x00A8214C File Offset: 0x00A8034C
		public void Abort()
		{
			this.AbortSignal.Abort();
		}

		// Token: 0x04018699 RID: 99993
		private bool StopRequested;

		// Token: 0x0401869A RID: 99994
		private readonly ISequenceAbortSignal AbortSignal;
	}
}
