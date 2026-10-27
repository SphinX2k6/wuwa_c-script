using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006655 RID: 26197
	[NullableContext(1)]
	public interface IQueueNode
	{
		// Token: 0x1700961E RID: 38430
		// (get) Token: 0x06041AB0 RID: 268976
		// (set) Token: 0x06041AB1 RID: 268977
		IHexPos Point { get; set; }

		// Token: 0x1700961F RID: 38431
		// (get) Token: 0x06041AB2 RID: 268978
		// (set) Token: 0x06041AB3 RID: 268979
		[Nullable(2)]
		IQueueNode Next { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
