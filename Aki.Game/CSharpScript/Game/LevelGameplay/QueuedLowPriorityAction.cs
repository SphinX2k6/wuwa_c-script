using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AF0 RID: 23280
	[NullableContext(1)]
	[Nullable(0)]
	public class QueuedLowPriorityAction : IQueuedLowPriorityAction
	{
		// Token: 0x06039457 RID: 234583 RVA: 0x01009304 File Offset: 0x01007504
		public QueuedLowPriorityAction(int frameEnqueued, Action action)
		{
			this.FrameEnqueued = frameEnqueued;
			this.Action = action;
		}

		// Token: 0x17006D2E RID: 27950
		// (get) Token: 0x06039458 RID: 234584 RVA: 0x0100931A File Offset: 0x0100751A
		public int FrameEnqueued { get; }

		// Token: 0x17006D2F RID: 27951
		// (get) Token: 0x06039459 RID: 234585 RVA: 0x01009322 File Offset: 0x01007522
		public Action Action { get; }
	}
}
