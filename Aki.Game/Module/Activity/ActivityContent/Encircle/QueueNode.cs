using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003003 RID: 12291
	[NullableContext(1)]
	[Nullable(0)]
	public class QueueNode : IQueueNode
	{
		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0601D2D2 RID: 119506 RVA: 0x008E909D File Offset: 0x008E729D
		// (set) Token: 0x0601D2D3 RID: 119507 RVA: 0x008E90A5 File Offset: 0x008E72A5
		public IHexPos Point { get; set; }

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0601D2D4 RID: 119508 RVA: 0x008E90AE File Offset: 0x008E72AE
		// (set) Token: 0x0601D2D5 RID: 119509 RVA: 0x008E90B6 File Offset: 0x008E72B6
		[Nullable(2)]
		public IQueueNode Next { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
