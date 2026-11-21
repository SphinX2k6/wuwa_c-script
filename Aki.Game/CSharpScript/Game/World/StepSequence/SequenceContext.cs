using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.StepSequence
{
	// Token: 0x0200344B RID: 13387
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceContext
	{
		// Token: 0x0602226B RID: 139883 RVA: 0x009AD36A File Offset: 0x009AB56A
		public SequenceContext(ISequenceAbortSignal abortSignal)
		{
			this.AbortSignal = abortSignal;
		}

		// Token: 0x0602226C RID: 139884 RVA: 0x009AD37C File Offset: 0x009AB57C
		public void Stop()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "StepSequence:请求提前结束(Stop)", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StopRequested = true;
		}

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x0602226D RID: 139885 RVA: 0x009AD3AC File Offset: 0x009AB5AC
		public bool IsStopRequested
		{
			get
			{
				return this.StopRequested;
			}
		}

		// Token: 0x0602226E RID: 139886 RVA: 0x009AD3B4 File Offset: 0x009AB5B4
		public void Abort()
		{
			this.AbortSignal.Abort();
		}

		// Token: 0x04012CBD RID: 76989
		private bool StopRequested;

		// Token: 0x04012CBE RID: 76990
		private readonly ISequenceAbortSignal AbortSignal;
	}
}
