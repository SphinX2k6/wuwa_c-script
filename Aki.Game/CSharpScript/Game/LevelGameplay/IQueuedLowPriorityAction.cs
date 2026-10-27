using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006993 RID: 27027
	[NullableContext(1)]
	public interface IQueuedLowPriorityAction
	{
		// Token: 0x1700984C RID: 38988
		// (get) Token: 0x0604341D RID: 275485
		int FrameEnqueued { get; }

		// Token: 0x1700984D RID: 38989
		// (get) Token: 0x0604341E RID: 275486
		Action Action { get; }
	}
}
