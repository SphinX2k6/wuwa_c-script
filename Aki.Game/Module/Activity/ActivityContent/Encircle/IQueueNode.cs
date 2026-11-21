using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003002 RID: 12290
	[NullableContext(1)]
	public interface IQueueNode
	{
		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0601D2CE RID: 119502
		// (set) Token: 0x0601D2CF RID: 119503
		IHexPos Point { get; set; }

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0601D2D0 RID: 119504
		// (set) Token: 0x0601D2D1 RID: 119505
		[Nullable(2)]
		IQueueNode Next { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
