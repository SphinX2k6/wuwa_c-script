using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004180 RID: 16768
	[NullableContext(1)]
	public interface ICollectCardDetailViewOpenParam
	{
		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x0602A7B2 RID: 174002
		// (set) Token: 0x0602A7B3 RID: 174003
		int CardId { get; set; }

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x0602A7B4 RID: 174004
		// (set) Token: 0x0602A7B5 RID: 174005
		int ActivityId { get; set; }

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x0602A7B6 RID: 174006
		// (set) Token: 0x0602A7B7 RID: 174007
		Action<int> CallbackOnClose { get; set; }
	}
}
