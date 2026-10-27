using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B0 RID: 20912
	[NullableContext(1)]
	public interface ICollectCardDetailViewOpenParam
	{
		// Token: 0x170081A8 RID: 33192
		// (get) Token: 0x060358B7 RID: 219319
		// (set) Token: 0x060358B8 RID: 219320
		int CardId { get; set; }

		// Token: 0x170081A9 RID: 33193
		// (get) Token: 0x060358B9 RID: 219321
		// (set) Token: 0x060358BA RID: 219322
		int ActivityId { get; set; }

		// Token: 0x170081AA RID: 33194
		// (get) Token: 0x060358BB RID: 219323
		// (set) Token: 0x060358BC RID: 219324
		Action<int> CallbackOnClose { get; set; }
	}
}
