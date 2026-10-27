using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006994 RID: 27028
	[NullableContext(1)]
	[Nullable(0)]
	public class QueuedLowPriorityAction : IQueuedLowPriorityAction
	{
		// Token: 0x0604341F RID: 275487 RVA: 0x0106509C File Offset: 0x0106329C
		public QueuedLowPriorityAction(int frameEnqueued, Action action)
		{
			this.FrameEnqueued = frameEnqueued;
			this.Action = action;
		}

		// Token: 0x1700984E RID: 38990
		// (get) Token: 0x06043420 RID: 275488 RVA: 0x010650B2 File Offset: 0x010632B2
		public int FrameEnqueued { get; }

		// Token: 0x1700984F RID: 38991
		// (get) Token: 0x06043421 RID: 275489 RVA: 0x010650BA File Offset: 0x010632BA
		public Action Action { get; }
	}
}
