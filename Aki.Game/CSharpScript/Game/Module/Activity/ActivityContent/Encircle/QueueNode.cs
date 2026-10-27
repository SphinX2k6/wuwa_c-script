using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006656 RID: 26198
	[NullableContext(1)]
	[Nullable(0)]
	public class QueueNode : IQueueNode
	{
		// Token: 0x17009620 RID: 38432
		// (get) Token: 0x06041AB4 RID: 268980 RVA: 0x00FED681 File Offset: 0x00FEB881
		// (set) Token: 0x06041AB5 RID: 268981 RVA: 0x00FED689 File Offset: 0x00FEB889
		public IHexPos Point { get; set; }

		// Token: 0x17009621 RID: 38433
		// (get) Token: 0x06041AB6 RID: 268982 RVA: 0x00FED692 File Offset: 0x00FEB892
		// (set) Token: 0x06041AB7 RID: 268983 RVA: 0x00FED69A File Offset: 0x00FEB89A
		[Nullable(2)]
		public IQueueNode Next { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
