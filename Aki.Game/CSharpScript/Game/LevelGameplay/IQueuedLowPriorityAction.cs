using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AEF RID: 23279
	[NullableContext(1)]
	public interface IQueuedLowPriorityAction
	{
		// Token: 0x17006D2C RID: 27948
		// (get) Token: 0x06039455 RID: 234581
		int FrameEnqueued { get; }

		// Token: 0x17006D2D RID: 27949
		// (get) Token: 0x06039456 RID: 234582
		Action Action { get; }
	}
}
